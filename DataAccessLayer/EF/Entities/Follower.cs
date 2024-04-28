using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.EF.Entities
{
    public class Follower
    {
        [Key]
        public int FollowId { get; set; }

        [ForeignKey("UserFollower")]
        public int FollowerId { get; set; }
        [ForeignKey("UserFollowing")]
        public int FollowingId { get; set; }
        public DateTime FollowedOn { get; set; }

        public virtual User UserFollower { get; set; }

        public virtual User UserFollowing { get; set; }

        public Follower()
        {
            UserFollower = new User();
            UserFollowing = new User();
        }


    }
}
