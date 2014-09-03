using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Models.Album;
using XIMALAYACOPY.Core.Models.Category;
using XIMALAYACOPY.Core.Models.FocusImage;

namespace XIMALAYACOPY.Core.Models.Discover
{
    public class SuperExploreIndexResult : BaseResult
    {
        /// <summary>
        /// 焦点图
        /// </summary>
        public FocusImageResult FocusImages { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public CategoryResult Categories { get; set; }
        /// <summary>
        /// 最后一个专题
        /// </summary>
        public object LatestSpecial { get; set; }
        /// <summary>
        /// 最后一个活动
        /// </summary>
        public object LatestActivity { get; set; }
        /// <summary>
        /// 推荐专辑
        /// </summary>
        public AlbumInfoResult1 Albums { get; set; }

        public SuperExploreIndexResult()
            : base()
        {
            this.doAddMap(() => this.FocusImages, "focusImages");
            this.doAddMap(() => this.Categories, "categories");
            this.doAddMap(() => this.LatestActivity, "latest_activity");
            this.doAddMap(() => this.LatestSpecial, "latest_special");
            this.doAddMap(() => this.Albums, "recommendAlbums");
        }
    }
}
