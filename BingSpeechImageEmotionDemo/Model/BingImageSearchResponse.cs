using System;

public class BingImageSearchResponse
{
    public string _type { get; set; }
    public string readLink { get; set; }
    public string webSearchUrl { get; set; }
    public string webSearchUrlPingSuffix { get; set; }
    public int totalEstimatedMatches { get; set; }
    public Value[] value { get; set; }
    public int nextOffsetAddCount { get; set; }
    public bool displayShoppingSourcesBadges { get; set; }
    public bool displayRecipeSourcesBadges { get; set; }
}

public class Value
{
    public string name { get; set; }
    public string webSearchUrl { get; set; }
    public string webSearchUrlPingSuffix { get; set; }
    public string thumbnailUrl { get; set; }
    public DateTime datePublished { get; set; }
    public string contentUrl { get; set; }
    public string hostPageUrl { get; set; }
    public string hostPageUrlPingSuffix { get; set; }
    public string contentSize { get; set; }
    public string encodingFormat { get; set; }
    public string hostPageDisplayUrl { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string imageInsightsToken { get; set; }
    public string imageId { get; set; }
    public string accentColor { get; set; }
}



