﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Core.Services
{
    /// <summary>
    /// 分类下的标签接口
    /// </summary>
    public interface ICategoryTagService
    {
        /// <summary>
        /// 分类下的标签接口
        /// </summary>
        void GetData<T>(Action<object> act, T param);
    }


}
