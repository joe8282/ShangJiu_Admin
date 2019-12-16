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
    public class Dev_AwardBusiness : BaseBusiness<Dev_Award>, IDev_AwardBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_AwardDTO> GetDataList(Pagination pagination,
            string userName,
            string awardType,
            int? status,
            DateTime? startTime,
            DateTime? endTime,
            string subjectTitle)
        {
            Expression<Func<Dev_Award, Base_User, Dev_AwardDTO>> select = (a, b) => new Dev_AwardDTO
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
            var where = LinqHelper.True<Dev_AwardDTO>();
            if (!awardType.IsNullOrEmpty())
            {
                where = where.And(x => x.AwardType == awardType);
            }
            if (!status.IsNullOrEmpty() && Convert.ToInt16(status) > 0)
            {
                where = where.And(x => x.Status == status);
            }
            if (!subjectTitle.IsNullOrEmpty())
            {
                where = where.And(x => x.SubjectTitle.Contains(subjectTitle));
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

        public Dev_Award GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Award newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Award theData)
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