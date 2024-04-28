using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Entities
{
    public class User
    {
        [Key]
        public int UsertId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }

        public string AccType { get; set; }

        public DateTime AccCreatedAt { get; set; }

        public virtual ICollection<Article> Articles { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Like> Likes { get; set; }

        public virtual ICollection<Bookmark> Bookmarks { get; set; }




        public User()
        {
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            AccType = string.Empty;
            Articles = new List<Article>();

            Comments = new List<Comment>();
            Bookmarks = new List<Bookmark>();
            Likes = new List<Like>();


        }

    }
}
