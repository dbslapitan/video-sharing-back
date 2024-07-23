using VideoSharing.Models;

namespace VideoSharing.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VideoSharingContext context)
        {
            if(context.Users.Any() && context.Videos.Any())
            {
                return;
            }

            var previewUser = new User { Username = "preview" };

            context.Users.Add(previewUser);
            context.SaveChanges();
        }
    }
}
