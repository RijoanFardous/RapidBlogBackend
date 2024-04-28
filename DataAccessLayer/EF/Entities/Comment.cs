using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.EF.Entities
{
	public class Comment
	{
		[Key]
		public int CommentId { get; set; }
		[Required]
		[StringLength(200)]
		public string Content { get; set; }

		[ForeignKey("Article")]
		public int ArticleId { get; set; }

		[ForeignKey("User")]
		public int UserId { get; set; }
		public DateTime CommentedOn { get; set; }


		public virtual User User { get; set; }
		public virtual Article Article { get; set; }
		public Comment()
		{
			Content = string.Empty;
			User = new User();
			Article = new Article();
		}


	}
}

