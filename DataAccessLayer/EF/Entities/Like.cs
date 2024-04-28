using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.EF.Entities
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }

        [ForeignKey("Article")]
        public int ArticleId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime LikedOn { get; set; }

        public virtual User User { get; set; }

        public virtual Article Article { get; set; }

        public Like()
        {
            User = new User();
            Article = new Article();
        }


    }
}
