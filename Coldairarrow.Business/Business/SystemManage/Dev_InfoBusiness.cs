using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Coldairarrow.Business.SystemManage
{
    public class Dev_InfoBusiness : BaseBusiness<Dev_Info>, IDev_InfoBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_InfoDTO> GetDataList(Pagination pagination, 
            string infoType,
            int? status,
            string infoTitle,
            string receiverName,
            DateTime? startTime,
            DateTime? endTime)
        {
            Expression<Func<Dev_Info, Base_User, Dev_InfoDTO>> select = (a, b) => new Dev_InfoDTO
            {
                UserName = b.UserName,
                RealName = b.RealName
            };
            select = select.BuildExtendSelectExpre();
            var q_infos = GetIQueryable();
            var q = from a in q_infos.AsExpandable()
                    join b in Service.GetIQueryable <Base_User>() on a.UserId equals b.Id into ab
                    from b in ab.DefaultIfEmpty()
                    select @select.Invoke(a, b);
            var where = LinqHelper.True<Dev_InfoDTO>();
            if (!infoType.IsNullOrEmpty())
            {
                where = where.And(x => x.InfoType == infoType);
            }
            if (!status.IsNullOrEmpty() && status > 0)
            {
                where = where.And(x => x.Status == status);
            }
            if (!infoTitle.IsNullOrEmpty())
            {
                where = where.And(x => x.InfoTitle.Contains(infoTitle));
            }
            if (!receiverName.IsNullOrEmpty())
            {
                where = where.And(x => x.UserName.Contains(receiverName));
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

        public Dev_Info GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Info newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Info theData)
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