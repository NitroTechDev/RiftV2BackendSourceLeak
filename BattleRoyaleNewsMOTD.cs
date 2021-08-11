// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNewsMOTD
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNewsMOTD : PagesMOTD
  {
    public BattleRoyaleNewsMOTD(
      string title,
      string body,
      string image,
      string tileImage,
      string type = "Text")
      : base(title, body, type)
    {
      this.Image = image;
      this.TileImage = tileImage;
    }

    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("tileImage")]
    public string TileImage { get; set; }
  }
}
