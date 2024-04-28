using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.EF.Entities
{
	public class Comment
	{
		[Key]
		public int CommentId { get; set; }
		[Required]
		[StringLength(200)]
		public string Content { get; set; }

		public int ArticleId { get; set; }
		public int UserId { get; set; }
		public DateTime CommentedOn { get; set; }


		public Comment()
		{
			Content = string.Empty;
		}


	}
}

