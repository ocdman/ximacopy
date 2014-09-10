using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Events
{
    /// <summary>
    /// 标签事件
    /// </summary>
    public class TagEventArgument
    {
        /// <summary>
        /// 分类名
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 标准key
        /// </summary>
        public string TagKey { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { get; set; }
        /// <summary>
        /// 标签标题
        /// </summary>
        public string Title { get; set; }
    }

    class TagEvent : CompositePresentationEvent<TagEventArgument>
    {

    }
}
