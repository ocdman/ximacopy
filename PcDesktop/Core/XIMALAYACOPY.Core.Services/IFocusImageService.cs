using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Core.Services
{
    /// <summary>
    /// 焦点图接口
    /// </summary>
    public interface IFocusImageService
    {
        /// <summary>
        /// 获取数据接口
        /// </summary>
        void GetData<T>(Action<object> act, T param);
    }
}
