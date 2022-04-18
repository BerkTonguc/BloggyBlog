using BloggyBlog.Entities.Concrete;
using BloggyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggyBlog.Data.Abstract
{
    public interface IArticleRepository :EfEntityRepositoryBase<Article>
    {
        
    }
}
