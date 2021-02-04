namespace eNews.Common.Models.Enums
{
    public enum NewsSourceType : short
    {
        Internal = 1,
        External = 2
    }

    public enum NewsCategoryType : short
    {
        World = 1,
        Political = 2,
        Sports = 3,
        Travel = 4,
        Advertisements = 5,
        Business = 6,
        Finance = 7,
        Entertainment = 8,
        Lifestyle = 9,
        Technology = 10
    }

    public enum NewsPriority : short
    {
        High,
        Medium,
        Low
    }

    public enum NewsSection : short
    {
        MyFeed,
        AllNews,
        TopStories,
        Trending,
        Bookmark,
        BreakingNews
    }

    public enum AdvertisementCategoryType : short
    {
        PaidSearch = 1,
        SocialMedia = 2,
        Native = 3,
        Display = 4,
        Print = 5,
        Broadcast = 6,
        Outdoor = 7
    }
}