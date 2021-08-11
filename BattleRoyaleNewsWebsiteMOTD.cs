// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNewsWebsiteMOTD
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNewsWebsiteMOTD : BattleRoyaleNewsMOTD
  {
    public BattleRoyaleNewsWebsiteMOTD(
      string title,
      string body,
      string image,
      string tileImage,
      string website,
      string websiteText = null)
      : base(title, body, image, tileImage, "Website")
    {
      this.WebsiteURL = website;
      this.WebsiteButtonText = websiteText;
    }

    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    [JsonProperty("websiteButtonText")]
    public string WebsiteButtonText { get; set; }
  }
}
