using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.MaterialManage;
using YiSha.Business.MaterialManage;
using YiSha.Model.Param.MaterialManage;

namespace YiSha.Admin.Web.Areas.MaterialManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-22 14:28
    /// 描 述：Erpwarehouse控制器类
    /// </summary>
    [Area("MaterialManage")]
    public class ErpwarehouseController :  BaseController
    {
        private ErpwarehouseBLL erpwarehouseBLL = new ErpwarehouseBLL();

        #region 视图功能
        [AuthorizeFilter("material:erpwarehouse:view")]
        public ActionResult ErpwarehouseIndex()
        {
            return View();
        }

        public ActionResult ErpwarehouseForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("material:erpwarehouse:search")]
        public async Task<ActionResult> GetListJson(ErpwarehouseListParam param)
        {
            TData<List<ErpwarehouseEntity>> obj = await erpwarehouseBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("material:erpwarehouse:search")]
        public async Task<ActionResult> GetPageListJson(ErpwarehouseListParam param, Pagination pagination)
        {
            TData<List<ErpwarehouseEntity>> obj = await erpwarehouseBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<ErpwarehouseEntity> obj = await erpwarehouseBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("material:erpwarehouse:add,material:erpwarehouse:edit")]
        public async Task<ActionResult> SaveFormJson(ErpwarehouseEntity entity)
        {
            TData<string> obj = await erpwarehouseBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("material:erpwarehouse:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await erpwarehouseBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
