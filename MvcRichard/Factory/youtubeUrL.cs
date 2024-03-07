using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


class youTubeUrl
{
    public Array getYouTubeUrls()
    {
        // Your JSON string
        string jsonString = @"{
          ""kind"": ""youtube#playlistItemListResponse"",
          ""etag"": ""FwUyNOrzPgAYwdKNr45qdOBtRhk"",
          ""items"": [
            {
              ""kind"": ""youtube#playlistItem"",
              ""etag"": ""vZK9AenLoddiVjiLnpGiIQEs6rc"",
              ""id"": ""UEw5cXNleE40QThqd1RhMGtLX041bTdBdGkycFBQeHpxVC41MzJCQjBCNDIyRkJDN0VD"",
              ""snippet"": {
                ""publishedAt"": ""2024-03-03T22:34:21Z"",
                ""channelId"": ""UCTycocR4wUXS35LCfJBU3uw"",
                ""title"": ""Intro"",
                ""description"": ""Fletcher Soul Traveler\nClick on link for PDF https://evolutionrevolutionoflove.com/PDF/CD/beautifulday.pdf"",
                ""thumbnails"": {
                  ""default"": {
                    ""url"": ""https://i.ytimg.com/vi/BxPCqUYHo74/default.jpg"",
                    ""width"": 120,
                    ""height"": 90
                  },
                  ""medium"": {
                    ""url"": ""https://i.ytimg.com/vi/BxPCqUYHo74/mqdefault.jpg"",
                    ""width"": 320,
                    ""height"": 180
                  },
                  ""high"": {
                    ""url"": ""https://i.ytimg.com/vi/BxPCqUYHo74/hqdefault.jpg"",
                    ""width"": 480,
                    ""height"": 360
                  },
                  ""standard"": {
                    ""url"": ""https://i.ytimg.com/vi/BxPCqUYHo74/sddefault.jpg"",
                    ""width"": 640,
                    ""height"": 480
                  },
                  ""maxres"": {
                    ""url"": ""https://i.ytimg.com/vi/BxPCqUYHo74/maxresdefault.jpg"",
                    ""width"": 1280,
                    ""height"": 720
                  }
                },
                ""channelTitle"": ""Fletcher Soul Traveler"",
                ""playlistId"": ""PL9qsexN4A8jwTa0kK_N5m7Ati2pPPxzqT"",
                ""position"": 0,
                ""resourceId"": {
                  ""kind"": ""youtube#video"",
                  ""videoId"": ""BxPCqUYHo74""
                },
                ""videoOwnerChannelTitle"": ""Fletcher Soul Traveler"",
                ""videoOwnerChannelId"": ""UCTycocR4wUXS35LCfJBU3uw""
              },
              ""contentDetails"": {
                ""videoId"": ""BxPCqUYHo74"",
                ""videoPublishedAt"": ""2024-03-03T22:40:13Z""
              }
            },
            // ... (similar blocks for other items)
          ]
        }";

        // Deserialize the JSON string to a C# object
        var playlistResponse = JsonConvert.DeserializeObject<PlaylistItemListResponse>(jsonString);

        // Access the array of items
        var itemsArray = playlistResponse.Items;

        // Do something with the array, e.g., iterate through items
        foreach (var item in itemsArray)
        {
            Console.WriteLine($"Title: {item.Snippet.Title}, Video ID: {item.Snippet.ResourceId.VideoId}");
        }

        return itemsArray;
    }
}

// Classes to represent the structure of the JSON
public class PlaylistItemListResponse
{
    public string Kind { get; set; }
    public string Etag { get; set; }
    public PlaylistItem[] Items { get; set; }
}

public class PlaylistItem
{
    public string Kind { get; set; }
    public string Etag { get; set; }
    public string Id { get; set; }
    public Snippet Snippet { get; set; }
    public ContentDetails ContentDetails { get; set; }
}

public class Snippet
{
    public DateTime PublishedAt { get; set; }
    public string ChannelId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Thumbnails Thumbnails { get; set; }
    public string ChannelTitle { get; set; }
    public string PlaylistId { get; set; }
    public int Position { get; set; }
    public ResourceId ResourceId { get; set; }
    public string VideoOwnerChannelTitle { get; set; }
    public string VideoOwnerChannelId { get; set; }
}

public class Thumbnails
{
    public Thumbnail Default { get; set; }
    public Thumbnail Medium { get; set; }
    public Thumbnail High { get; set; }
    public Thumbnail Standard { get; set; }
    public Thumbnail Maxres { get; set; }
}

public class Thumbnail
{
    public string Url { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}

public class ResourceId
{
    public string Kind { get; set; }
    public string VideoId { get; set; }
}

public class ContentDetails
{
    public string VideoId { get; set; }
    public DateTime VideoPublishedAt { get; set; }
}
