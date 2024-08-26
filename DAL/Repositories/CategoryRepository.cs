using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    /// <summary>
    ///  Implements both, just in case of additional logic in-side ICategoryRepository which doesn't exists in the Generic 
    ///  the Generic is made for Mostly used Functions like CRUD Operations 
    /// </summary>
    public class CategoryRepository: GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository() : base() { }

    }
}
