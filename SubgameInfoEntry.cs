// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.SubgameInfoEntry
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class SubgameInfoEntry : BasePagesEntry
  {
    [JsonProperty("battleroyale")]
    public SubgameInfo BattleRoyale { get; set; }

    [JsonProperty("savetheworld")]
    public SubgameInfo SaveTheWorld { get; set; }

    [JsonProperty("creative")]
    public SubgameInfo Creative { get; set; }

    public SubgameInfoEntry()
      : base("SubgameInfo")
    {
    }
  }
}
