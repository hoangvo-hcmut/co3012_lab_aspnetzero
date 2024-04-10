using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Zero.EntityFrameworkCore;
using MyCompanyName.AbpZeroTemplate.EntityFrameworkCore;

namespace MyCompanyName.AbpZeroTemplate.Migrations.Seed.Host
{
    public class InitialBookCreator
    {
        private readonly AbpZeroTemplateDbContext _context;

        public InitialBookCreator(AbpZeroTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var book1 = _context.Books.FirstOrDefault(p => p.Title == "Giai tich");
            if (book1 == null)
            {
                _context.Books.Add(
                    new Search.Book
                    {
                        Title = "Giai tich",
                        AuthorName = "HCMUT"
                    }
                );
            }

            var book2 = _context.Books.FirstOrDefault(p => p.Title == "Triet hoc Mac-Lenin");
            if (book2 == null)
            {
                _context.Books.Add(
                    new Search.Book
                    {
                        Title = "Triet hoc Mac-Lenin",
                        AuthorName = "HCMUT"
                    }
                );
            }
        }
    }
}
