using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.OtherManage
{
    public class Dev_PictureBusiness : BaseBusiness<Dev_Picture>, IDev_PictureBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_Picture> GetDataList(Pagination pagination, string PictureType, int? Status, string Title, DateTime? startTime, DateTime? endTime)
        {
            var q = GetIQueryable();

            var where = LinqHelper.True<Dev_Picture>();

            //筛选
            if (!PictureType.IsNullOrEmpty())
               where=where.And(m => m.PictureType.Equals(PictureType));
            if (!Status.IsNullOrEmpty() && Status > 0)
                where = where.And(m => m.Status== Status);
            if (!Title.IsNullOrEmpty())
                where = where.And(m => m.Title.Contains(Title));
            if (!startTime.IsNullOrEmpty())
            {
                where = where.And(x => x.CreateTime >= startTime);
            }
            if (!endTime.IsNullOrEmpty())
            {
                where = where.And(x => x.CreateTime <= endTime);
            }

            // return q.GetPagination(pagination).ToList();
            return q.Where(where).GetPagination(pagination).ToList();





        }

        public Dev_Picture GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Picture newData)
        {
            newData.ClickNum = 0;
            newData.CreateTime = DateTime.Now;
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Picture theData)
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