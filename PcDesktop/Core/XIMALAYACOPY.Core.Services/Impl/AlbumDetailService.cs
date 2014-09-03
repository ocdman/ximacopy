using FluentJson;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Data;
using XIMALAYACOPY.Core.Data.Decorator;
using XIMALAYACOPY.Core.Models.Album;
using XIMALAYACOPY.Tools;

namespace XIMALAYACOPY.Core.Services.Impl
{
    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(IAlbumDetailService))]
    public class AlbumDetailService : ServiceBase<AlbumInfoResult>, IAlbumDetailService
    {
        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected IAlbumInfoResultRepository Repository { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void GetData<T>(Action<object> act, T param)
        {
            Result<AlbumInfoResult> result = new Result<AlbumInfoResult>();

            new AlbumInfoResultDecorator<AlbumInfoResult>(result);
            new SoundsResultDecorator<AlbumInfoResult>(result);
            new AlbumData3Decorator<AlbumInfoResult>(result);
            new SoundData2Decorator<AlbumInfoResult>(result);
            this.Act = act;
            this.Decoder = Json.DecoderFor<AlbumInfoResult>(config => config.DeriveFrom(result.Config));

            this.Repository.Fetch(WellKnownUrl.AlbumInfo, param.ToString(), base.GetDataCallBack);
        }
    }
}
