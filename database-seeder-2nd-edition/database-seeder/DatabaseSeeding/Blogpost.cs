using Newtonsoft.Json;

namespace CosmosDBPlayground.DatabaseSeeding;

internal class BlogPost
{
    [JsonProperty(PropertyName = "id")]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime? PublishedDate { get; set; }
    public string BlogPostMarkdown { get; set; }
    public IEnumerable<string> Tags { get; set; }
    public Status Status { get; set; }

}

internal enum Status
{
    Draft = 1,
    Published = 2,
    Deleted = 3
}
