using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Core.Data
{
    /// <summary>
    /// 数据操作接口
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// 获得数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="datas"></param>
        /// <param name="async"></param>
        /// <param name="IsPost"></param>
        void Fetch(string url, string datas, AsyncCallback async, bool IsPost = false);
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="datas"></param>
        /// <param name="async"></param>
        /// <param name="IsPost"></param>
        void Add(string url, string datas, AsyncCallback async, bool IsPost = false);
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="datas"></param>
        /// <param name="async"></param>
        /// <param name="IsPost"></param>
        void Edit(string url, string datas, AsyncCallback async, bool IsPost = false);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="datas"></param>
        /// <param name="async"></param>
        /// <param name="IsPost"></param>
        void Del(string url, string datas, AsyncCallback async, bool IsPost = false);
    }
}
