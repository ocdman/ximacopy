﻿
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
//		如存在本生成代码外的新需求，请在相同命名空间下创建同名分部类实现 TagSoundListResultConfigurationAppend 分部方法。
// </auto-generated>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Composition;

using XIMALAYACOPY.Core.Data;
using XIMALAYACOPY.Core.Models. Tags;

namespace XIMALAYACOPY.Core.Data
{
    /// <summary>
    /// 分类查询操作
    /// </summary>
    [Export(typeof(ITagSoundListResultRepository))]
    public class TagSoundListResultRepository : RepositoryBase<TagSoundListResult>, ITagSoundListResultRepository
    {

    }
}

