using FluentJson;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Data;
using XIMALAYACOPY.Core.Data.Decorator;
using XIMALAYACOPY.Core.Models.Discover;
using XIMALAYACOPY.Tools;

namespace XIMALAYACOPY.Core.Services.Impl
{
    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(ISuperExploreIndexService))]
    public class SuperExploreIndexService : ServiceBase<SuperExploreIndexResult>, ISuperExploreIndexService
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Import]
        protected ISuperExploreIndexResultRepository Repository { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void GetData<T>(Action<object> act, T param)
        {
            Result<SuperExploreIndexResult> result = new Result<SuperExploreIndexResult>();

            new SuperExploreIndexResultDecorator<SuperExploreIndexResult>(result);
            //分类
            new CategoryResultDecorator<SuperExploreIndexResult>(result);
            new CategoryDataDecorator<SuperExploreIndexResult>(result);
            //焦点图
            new FocusImageResultDecorator<SuperExploreIndexResult>(result);
            new FocusImageDataDecorator<SuperExploreIndexResult>(result);
            //推荐用户
            //new UserDataDecorator<SuperExploreIndexResult>(result);
            //推荐专辑
            new AlbumInfoResult1Decorator<SuperExploreIndexResult>(result);
            new AlbumData1Decorator<SuperExploreIndexResult>(result);
            //专题列表
            //new SubjectListResultDecorator<SuperExploreIndexResult>(result);
            //new SubjectDataDecorator<SuperExploreIndexResult>(result);

            this.Act = act;
            this.Decoder = Json.DecoderFor<SuperExploreIndexResult>(config => config.DeriveFrom(result.Config));

            this.Repository.Fetch(WellKnownUrl.SuperExploreIndex, param.ToString(), GetDataCallBack);
        }
    }
}
