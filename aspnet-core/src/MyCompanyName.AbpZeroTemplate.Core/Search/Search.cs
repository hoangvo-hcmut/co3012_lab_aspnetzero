using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace MyCompanyName.AbpZeroTemplate.Search
{
    [Table("Book")]
    public class Book : FullAuditedEntity
    {
        public const int MaxTitleLength = 64;
        public const int MaxAuthorNameLength = 64;
        [Required]
        [MaxLength(MaxTitleLength)]
        public virtual string Title { get; set; }

        [Required]
        [MaxLength(MaxAuthorNameLength)]
        public virtual string AuthorName { get; set; }
    }
}
