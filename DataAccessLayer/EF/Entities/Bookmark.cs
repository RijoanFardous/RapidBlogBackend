using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.EF.Entities
{
	public class Bookmark
	{
		[Key]
		public int BookmarkId { get; set; }

		[ForeignKey("User")]
		public int UserId { get; set; }

		[ForeignKey("Article")]
		public int ArticleId { get; set; }


		public virtual User User { get; set; }
		public virtual Article Article { get; set; }

		public Bookmark()
		{
			User = new User();
			Article = new Article();
		}
       
    }
}

