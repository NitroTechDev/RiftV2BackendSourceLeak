// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.ItemVariant
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rift.Backend.Models.Profile
{
  public class ItemVariant
  {
    [JsonProperty("channel")]
    public string Channel { get; set; }

    [JsonProperty("active")]
    public string Active { get; set; }

    [JsonProperty("owned")]
    public List<string> Owned { get; set; }

    [JsonIgnore]
    public string Id { get; set; }
  }
}
