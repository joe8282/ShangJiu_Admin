using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Coldairarrow.Business.OtherManage
{
    public class Dev_CommentBusiness : BaseBusiness<Dev_Comment>, IDev_CommentBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_CommentDTO> GetDataList(Pagination pagination,
            string userName,
            string commentType,
            int? status,
            string subjectTitle,
            string commentContent,
            DateTime? startTime,
            DateTime? endTime)
        {
            Expression<Func<Dev_Comment, Base_User, Dev_CommentDTO>> select = (a, b) => new Dev_CommentDTO
            {
                UserName = b.UserName,
                RealName = b.RealName
            };
            select = select.BuildExtendSelectExpre();
            var q_infos = GetIQueryable();
            var q = from a in q_infos.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id into ab
                    from b in ab.DefaultIfEmpty()
                    select @select.Invoke(a, b);
            var where = LinqHelper.True<Dev_CommentDTO>();
            if (!commentType.IsNullOrEmpty())
            {
                where = where.And(x => x.CommentType == commentType);
            }
            if (!status.IsNullOrEmpty() && status > 0)
            {
                where = where.And(x => x.Status == status);
            }
            if (!subjectTitle.IsNullOrEmpty())
            {
                where = where.And(x => x.SubjectTitle.Contains(subjectTitle));
            }
            if (!commentContent.IsNullOrEmpty())
            {
                where = where.And(x => x.CommentContent.Contains(commentContent));
            }
            if (!userName.IsNullOrEmpty())
            {
                where = where.And(x => x.UserName.Contains(userName));
            }
            if (!startTime.IsNullOrEmpty())
            {
                where = where.And(x => x.CreateTime >= startTime);
            }
            if (!endTime.IsNullOrEmpty())
            {
                where = where.And(x => x.CreateTime <= endTime);
            }
            var list = q.Where(where).GetPagination(pagination).ToList();
            return list;
        }

        public Dev_Comment GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Comment newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Comment theData)
        {
            Update(theData);

            return Success();
        }

        public AjaxResult DeleteData(List<string> ids)
        {
            Delete(ids);

            return Success();
        }

        #endregion

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion
    }
}