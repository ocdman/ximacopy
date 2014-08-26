using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIMALAYACOPY.Core.Data.Decorator
{
    public abstract class ResultBase
    {
        public abstract void doAddConfig();
    }

    public class Result<T> : ResultBase
    {
        //public JsonConfiguration<T> Config { get; set; }

        public override void doAddConfig()
        {
            // throw new NotImplementedException();
        }
    }
}
