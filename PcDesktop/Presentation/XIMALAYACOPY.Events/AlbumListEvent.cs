using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Events
{
    /// <summary>
    /// 获取专辑列表数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AlbumListEvent<T> : CompositePresentationEvent<T> { }

    /// <summary>
    /// 专辑详情页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AlbumDetailEvent<T> : CompositePresentationEvent<T> { }
}
