using BloggyBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggyBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; set; } // ResultStatus.Success // ResultStatus.Error
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
