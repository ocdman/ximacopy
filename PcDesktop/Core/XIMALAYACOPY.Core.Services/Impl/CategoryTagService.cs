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
    /// 分类下的标签
    /// </summary>
    [Export(typeof(ICategoryTagService))]
    public class CategoryTagService : ServiceBase<CategoryTagResult>, ICategoryTagService
    {
        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected ICategoryTagResultRepository Repository { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void GetData<T>(Action<object> act, T param)
        {
            Result<CategoryTagResult> result = new Result<CategoryTagResult>();

            new CategoryTagResultDecorator<CategoryTagResult>(result);
            new TagDataDecorator<CategoryTagResult>(result);

            this.Act = act;
            this.Decoder = Json.DecoderFor<CategoryTagResult>(config => config.DeriveFrom(result.Config));

            this.Repository.Fetch(WellKnownUrl.CategoryTags, param.ToString(), GetDataCallBack);
        }
    }
}
