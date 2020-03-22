using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.MaterialManage;
using YiSha.Model.Param.MaterialManage;
using YiSha.Service.MaterialManage;

namespace YiSha.Business.MaterialManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-22 14:28
    /// 描 述：Erpwarehouse业务类
    /// </summary>
    public class ErpwarehouseBLL
    {
        private ErpwarehouseService erpwarehouseService = new ErpwarehouseService();

        #region 获取数据
        public async Task<TData<List<ErpwarehouseEntity>>> GetList(ErpwarehouseListParam param)
        {
            TData<List<ErpwarehouseEntity>> obj = new TData<List<ErpwarehouseEntity>>();
            obj.Result = await erpwarehouseService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<ErpwarehouseEntity>>> GetPageList(ErpwarehouseListParam param, Pagination pagination)
        {
            TData<List<ErpwarehouseEntity>> obj = new TData<List<ErpwarehouseEntity>>();
            obj.Result = await erpwarehouseService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<ErpwarehouseEntity>> GetEntity(long id)
        {
            TData<ErpwarehouseEntity> obj = new TData<ErpwarehouseEntity>();
            obj.Result = await erpwarehouseService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(ErpwarehouseEntity entity)
        {
            TData<string> obj = new TData<string>();
            await erpwarehouseService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await erpwarehouseService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
