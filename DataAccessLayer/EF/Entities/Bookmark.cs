using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.EF.Entities
{
	public class Bookmark
	{
		[Key]
		public int BookmarkId { get; set; }

		public int UserId { get; set; }

		public int ArticleId { get; set; }
       
    }
}

