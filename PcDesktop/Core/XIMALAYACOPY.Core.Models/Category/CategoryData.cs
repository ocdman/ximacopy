﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace XIMALAYACOPY.Core.Models.Category
{
    public class CategoryData : BaseData
    {
        /// <summary>
        /// id
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 标题 
        /// title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 名称
        /// name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否显示
        /// isChecked
        /// </summary>
        public bool IsChecked { get; set; }
        /// <summary>
        /// 图片
        /// cover_path
        /// </summary>
        public string CoverPath { get; set; }
        /// <summary>
        /// 排序
        /// orderNum
        /// </summary>
        public int OrderNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Geometry Path { get; set; }
        /// <summary>
        /// 分类下的声音数据
        /// </summary>
        public Sound.SoundData[] Sounds { get; set; }

        public CategoryData()
            : base()
        {
            this.doAddMap(() => this.ID, "id");
            this.doAddMap(() => this.Title, "title");
            this.doAddMap(() => this.CoverPath, "coverPath");
            this.doAddMap(() => this.IsChecked, "isChecked");
            this.doAddMap(() => this.OrderNum, "orderNum");
            this.doAddMap(() => this.Name, "name");
            this.doAddMap(() => this.Sounds, "sounds");
        }
    }
}
