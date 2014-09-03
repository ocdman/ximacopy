using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Core.Services
{
    /// <summary>
    /// 发现页接口
    /// </summary>
    public interface ISuperExploreIndexService
    {
        /// <summary>
        /// 获取数据接口
        /// </summary>
        void GetData<T>(Action<object> act, T param);
    }
}
