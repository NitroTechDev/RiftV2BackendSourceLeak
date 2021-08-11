// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Commands.Cosmetics.SetItemFavoriteStatusBatch
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rift.Backend.Models.Commands.Cosmetics
{
  public class SetItemFavoriteStatusBatch
  {
    [JsonRequired]
    [JsonProperty("itemIds")]
    public List<string> ItemIds { get; set; }

    [JsonRequired]
    [JsonProperty("itemFavStatus")]
    public List<bool> ItemFavStatus { get; set; }
  }
}
