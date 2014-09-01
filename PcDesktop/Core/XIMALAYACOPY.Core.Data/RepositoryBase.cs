using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIMALAYACOPY.Core.Models;

namespace XIMALAYACOPY.Core.Data
{
    public abstract class RepositoryBase<T> : IRepository
        where T : Base
    {

        public void Fetch(string url, string datas, AsyncCallback async, bool IsPost = false)
        {
            throw new NotImplementedException();
        }

        public void Add(string url, string datas, AsyncCallback async, bool IsPost = false)
        {
            throw new NotImplementedException();
        }

        public void Edit(string url, string datas, AsyncCallback async, bool IsPost = false)
        {
            throw new NotImplementedException();
        }

        public void Del(string url, string datas, AsyncCallback async, bool IsPost = false)
        {
            throw new NotImplementedException();
        }
    }
}
