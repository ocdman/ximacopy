using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Models.User;

namespace XIMALAYACOPY.Core.Models.Search
{
    /// <summary>
    /// 搜索声音数据
    /// </summary>
    public class SearchUserResult : BaseResult
    {
        /// <summary>
        /// start，起始位置
        /// </summary>
        public long StartAt { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public long TotalCount { get; set; }
        /// <summary>
        /// 声音列表
        /// </summary>
        public UserData[] Users { get; set; }
        /// <summary>
        /// 构造
        /// </summary>
        public SearchUserResult()
        {
            this.doAddMap(() => this.StartAt, "start");
            this.doAddMap(() => this.TotalCount, "numFound");
            this.doAddMap(() => this.Users, "docs");
        }
    }
}
