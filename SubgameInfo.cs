// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.SubgameInfo
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class SubgameInfo
  {
    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("color")]
    public string Color { get; set; }

    [JsonProperty("specialMessage")]
    public string SpecialMessage { get; set; }

    [JsonProperty("_type")]
    public string Type => "Subgame Info";

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("subgame")]
    public string Subgame { get; set; }

    [JsonProperty("standardMessageLine2")]
    public string StandardMessageLine2 { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("standardMessageLine1")]
    public string StandardMessageLine1 { get; set; }

    public SubgameInfo(
      string title,
      string description,
      string subgame,
      string image,
      string color = null)
    {
      this.Image = image;
      this.Title = title;
      this.Description = description;
      this.Subgame = subgame;
      this.Color = color ?? "000000";
    }
  }
}
