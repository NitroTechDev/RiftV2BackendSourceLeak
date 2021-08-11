// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.SubgameSelectEntry
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class SubgameSelectEntry : BasePagesEntry
  {
    [JsonProperty("saveTheWorldUnowned", Order = -7)]
    public PagesMessage SaveTheWorldUnowned => this.SaveTheWorld;

    [JsonProperty("battleRoyale", Order = -7)]
    public PagesMessage BattleRoyale { get; set; }

    [JsonProperty("creative", Order = -7)]
    public PagesMessage Creative { get; set; }

    [JsonProperty("saveTheWorld", Order = -7)]
    public PagesMessage SaveTheWorld { get; set; }

    public SubgameSelectEntry()
      : base("subgameselectdata")
    {
    }
  }
}
