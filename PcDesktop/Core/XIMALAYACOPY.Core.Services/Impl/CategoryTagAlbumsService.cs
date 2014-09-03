using FluentJson;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Data;
using XIMALAYACOPY.Core.Data.Decorator;
using XIMALAYACOPY.Core.Models.Tags;
using XIMALAYACOPY.Tools;

namespace XIMALAYACOPY.Core.Services.Impl
{
    /// <summary>
    /// 分类下的标签下的专辑
    /// </summary>
    [Export(typeof(ICategoryTagAlbumsService))]
    public class CategoryTagAlbumsService : ServiceBase<TagAlbumsResult>, ICategoryTagAlbumsService
    {
        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected ITagAlbumsResultRepository Repository { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void GetData<T>(Action<object> act, T param)
        {
            Result<TagAlbumsResult> result = new Result<TagAlbumsResult>();

            new TagAlbumsResultDecorator<TagAlbumsResult>(result);
            new AlbumData1Decorator<TagAlbumsResult>(result);

            this.Act = act;
            this.Decoder = Json.DecoderFor<TagAlbumsResult>(config => config.DeriveFrom(result.Config));

            this.Repository.Fetch(WellKnownUrl.CategoryTagAlbums, param.ToString(), GetDataCallBack);
        }
    }
}
