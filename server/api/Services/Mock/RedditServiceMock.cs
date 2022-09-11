using fr.pierrejulien.ddit.api.Models;

namespace fr.pierrejulien.ddit.api.Services.Mock;

public class RedditServiceMock : IRedditService
{
    private readonly IEnumerable<RedditModel> _reddits = new List<RedditModel>
    {
        new RedditModel
        {
            Name = "initiald",
            Followers = 62_800,
            Picture = "https://styles.redditmedia.com/t5_2t9bc/styles/communityIcon_hll1tb0ykuz81.png?width=256&s=6ac6c46a3e03b5e2a9ddaaf281577bde8bf916ec"
        },
        new RedditModel
        {
            Name = "place",
            Followers = 5_400_000,
            Picture = "https://styles.redditmedia.com/t5_2sxhs/styles/communityIcon_5ejpm2gtctq81.png?width=256&s=66292afe20bb85730f4192931b01da86e75acfaa",
        },
        new RedditModel
        {
            Name = "simracing",
            Followers = 244_000,
            Picture = "https://styles.redditmedia.com/t5_2quee/styles/communityIcon_fxk55j1c4mm81.png?width=256&s=b125b9711abaac3712dbaf7addc2ff6d8752afeb"
        }
    };

    public Task<IEnumerable<RedditModel>> Get() => Task.FromResult(_reddits);
}
