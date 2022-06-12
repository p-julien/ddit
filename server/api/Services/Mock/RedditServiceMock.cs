using api.Models;

namespace api.Services.Mock
{
    public class RedditServiceMock : IRedditService
    {
        private readonly IEnumerable<Reddit> _reddits = new List<Reddit>
        {
            new Reddit
            {
                Name = "initiald",
                Followers = 62_800,
                PictureUrl = "https://styles.redditmedia.com/t5_2t9bc/styles/communityIcon_hll1tb0ykuz81.png?width=256&s=6ac6c46a3e03b5e2a9ddaaf281577bde8bf916ec"
            },
            new Reddit
            {
                Name = "place",
                Followers = 5_400_000,
                PictureUrl = "https://styles.redditmedia.com/t5_2sxhs/styles/communityIcon_5ejpm2gtctq81.png?width=256&s=66292afe20bb85730f4192931b01da86e75acfaa",
            },
            new Reddit
            {
                Name = "simracing",
                Followers = 244_000,
                PictureUrl = "https://styles.redditmedia.com/t5_2quee/styles/communityIcon_fxk55j1c4mm81.png?width=256&s=b125b9711abaac3712dbaf7addc2ff6d8752afeb"
            }
        };
        
        public IEnumerable<Reddit> Get() => _reddits;
    }
}
