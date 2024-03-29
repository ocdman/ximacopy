﻿
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
//		如存在本生成代码外的新需求，请在相同命名空间下创建同名分部类实现 SearchResultConfigurationAppend 分部方法。
// </auto-generated>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentJson.Configuration;
using FluentJson;
using XIMALAYACOPY.Core.Data.Decorator;
using XIMALAYACOPY.Core.Models.Search;

namespace XIMALAYACOPY.Core.Data
{
    /// <summary>
    ///     SearchResult
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class SearchResultDecorator<T> : Decorator<T>
    {
        partial void doAddOtherConfig();
        /// <summary>
        ///     
        /// </summary>
        /// <typeparam name="result"></typeparam>
        public SearchResultDecorator(Result<T> result)
            : base(result)
        {

        }
        /// <summary>
        ///     
        /// </summary>
        /// <typeparam name="result"></typeparam>
        public override void doAddConfig()
        {
            base.doAddConfig();
            this.Config.MapType<SearchResult>(map => map
                
                    .Field<System.Int32>(field => field.Ret, type => type.To("ret"))

                    .Field<System.String>(field => field.Message, type => type.To("msg"))

                    .Field<XIMALAYACOPY.Core.Models.Search.SearchAlbumResult>(field => field.AlbumData, type => type.To("album"))

                    .Field<XIMALAYACOPY.Core.Models.Search.SearchSoundResult>(field => field.SoundData, type => type.To("track"))

                    .Field<XIMALAYACOPY.Core.Models.Search.SearchUserResult>(field => field.UserData, type => type.To("user"))

            );
            this.doAddOtherConfig();
        }
    }
}
