// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.ItemAttributes
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rift.Backend.Models.Profile
{
  public class ItemAttributes
  {
    [JsonProperty("max_level_bonus")]
    public int MaxLevelBonus => 1;

    [JsonProperty("level")]
    public int Level => 1;

    [JsonProperty("item_seen")]
    public bool ItemSeen => true;

    [JsonProperty("xp")]
    public int Xp => 0;

    [JsonProperty("variants", NullValueHandling = NullValueHandling.Ignore)]
    public List<ItemVariant> Variants { get; set; }

    [JsonProperty("favorite")]
    public bool Favorite => false;
  }
}
