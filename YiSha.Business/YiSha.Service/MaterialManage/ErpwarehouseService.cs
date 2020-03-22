using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.MaterialManage;
using YiSha.Model.Param.MaterialManage;

namespace YiSha.Service.MaterialManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-22 14:28
    /// 描 述：Erpwarehouse服务类
    /// </summary>
    public class ErpwarehouseService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<ErpwarehouseEntity>> GetList(ErpwarehouseListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<ErpwarehouseEntity>> GetPageList(ErpwarehouseListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<ErpwarehouseEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<ErpwarehouseEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(ErpwarehouseEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<ErpwarehouseEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<ErpwarehouseEntity, bool>> ListFilter(ErpwarehouseListParam param)
        {
            var expression = LinqExtensions.True<ErpwarehouseEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
