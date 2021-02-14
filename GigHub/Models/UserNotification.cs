using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Models
{
    public class UserNotification
    {
        [Key]
        [Column(Order=1)]
        public string UserId { get; private set; }
        [Key]
        [Column(Order = 2)]
        public int NotificationId { get; private set; }

        public ApplicationUser User { get; private set; }
        public Notification Notification { get; private set; }
        public bool IsRead { get; set; }

        // allow EF to create instances of User Notifications
        protected UserNotification()
        {

        }

        // ensure valid state when user create instances
        public UserNotification(ApplicationUser user, Notification notification)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            
            if (notification == null)
                throw new ArgumentNullException(nameof(notification));

            User = user;
            Notification = notification;
        }
    }
}