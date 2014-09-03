using FluentJson;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Data;
using XIMALAYACOPY.Core.Data.Decorator;
using XIMALAYACOPY.Core.Models.FocusImage;
using XIMALAYACOPY.Tools;

namespace XIMALAYACOPY.Core.Services.Impl
{
    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(IFocusImageService))]
    public class FocusImageService : ServiceBase<FocusImageResult>, IFocusImageService
    {
        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected IFocusImageResultRepository Repository { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void GetData<T>(Action<object> act, T param)
        {
            Result<FocusImageResult> result = new Result<FocusImageResult>();

            new FocusImageResultDecorator<FocusImageResult>(result);
            new FocusImageDataDecorator<FocusImageResult>(result);
            this.Act = act;
            this.Decoder = Json.DecoderFor<FocusImageResult>(config => config.DeriveFrom(result.Config));

            this.Repository.Fetch(WellKnownUrl.FocsImage, param.ToString(), base.GetDataCallBack);
        }
    }
}
