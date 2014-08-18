using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SmartTracking.Entities
{
    public class VisitorRecord
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 访客标识
        /// </summary>
        [StringLength(32)]
        public string TraceCode { get; set; }

        /// <summary>
        /// 访客地址
        /// </summary>
        [StringLength(15)]
        public string UserIpAddress { get; set; }

        /// <summary>
        /// 主机域名
        /// </summary>
        [StringLength(200)]
        public string Domain { get; set; }

        /// <summary>
        /// 访问页面
        /// </summary>
        [StringLength(4000)]
        public string Uri { get; set; }

        /// <summary>
        /// 访问来源
        /// </summary>
        [StringLength(4000)]
        public string Referrer { get; set; }

        /// <summary>
        /// 屏幕高度
        /// </summary>
        public int ScreenHeight { get; set; }

        /// <summary>
        /// 屏幕宽度
        /// </summary>
        public int ScreenWidth { get; set; }

        /// <summary>
        /// 位深
        /// </summary>
        public int BitDepth { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [StringLength(20)]
        public string Language { get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        [StringLength(1024)]
        public string UserAgent { get; set; }

        /// <summary>
        /// 追踪账户
        /// </summary>
        [StringLength(50)]
        public string Account { get; set; }

        /// <summary>
        /// 追踪事件
        /// </summary>
        [Required]
        [StringLength(20)]
        public string TraceEvent { get; set; }

        /// <summary>
        /// 事件数据
        /// </summary>
        [StringLength(4000)]
        public string TraceEventData { get; set; }

        /// <summary>
        /// 访问时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }

        public VisitorRecord()
        {
            TraceCode = string.Empty;
            UserIpAddress = string.Empty;
            Domain = string.Empty;
            Uri = string.Empty;
            Referrer = string.Empty;
            Language = string.Empty;
            UserAgent = string.Empty;
            Account = string.Empty;
            TraceEvent = string.Empty;
            TraceEventData = string.Empty;
        }
    }
}