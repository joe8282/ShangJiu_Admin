using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Coldairarrow.Business.Help
{
    public class Dev_HelpBusiness : BaseBusiness<Dev_Help>, IDev_HelpBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_HelpDTO> GetDataList(Pagination pagination, bool all, string TypeId, int? Status, string HelpTitle, DateTime? startTime, DateTime? endTime)
        {

            Expression<Func<Dev_Help, Dev_HelpType, Dev_HelpDTO>> select = (a, b) => new Dev_HelpDTO
            {
               Name=b.Name
            };
            select = select.BuildExtendSelectExpre();
            var q_Dev_Help = all ? Service.GetIQueryable<Dev_Help>() : GetIQueryable();
            var q = from a in q_Dev_Help.AsExpandable()
                    join b in Service.GetIQueryable<Dev_HelpType>() on a.TypeId equals b.Id into ab
                    from b in ab.DefaultIfEmpty()
                    select @select.Invoke(a, b);

            var where = LinqHelper.True<Dev_HelpDTO>();
            if (!TypeId.IsNullOrEmpty())
                where = where.And(x => x.TypeId == TypeId);
            if (!Status.IsNullOrEmpty() && Status > 0)
                where = where.And(x => x.Status == Status);
            if (!HelpTitle.IsNullOrEmpty())
                where = where.And(x => x.HelpTitle.Contains(HelpTitle));
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

        public Dev_Help GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Help newData)
        {
            newData.CreateTime = DateTime.Now;
            newData.ClickNum = 0;
            newData.CommentNum = 0;
            newData.CollectNum = 0;
            newData.GoodNum = 0;
            newData.RewardFee = 0;

            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Help theData)
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