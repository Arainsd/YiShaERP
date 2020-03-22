using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.MaterialManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-22 14:28
    /// 描 述：Erpwarehouse实体类
    /// </summary>
    [Table("ErpWarehouse")]
    public class ErpwarehouseEntity : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public string WhCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string WhDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CreateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? CreateTime { get; set; }
    }
}
