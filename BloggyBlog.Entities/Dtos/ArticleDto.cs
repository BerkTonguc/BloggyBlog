using BloggyBlog.Entities.Concrete;
using BloggyBlog.Shared.Entities.Abstract;
using BloggyBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggyBlog.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }       
    }
}
