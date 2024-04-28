using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Entities
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        [StringLength(5000)]
        public string Content { get; set; }

        public string Audience { get; set; }

        [ForeignKey("User")]
        public int AuthorId { get; set; }

        public DateTime PostedAt { get; set; }

        public virtual User User { get; set; }

        public Article()
        {
            Title = string.Empty;
            Content = string.Empty;
            Audience = string.Empty;
            User = new User();
        }

    }
}
