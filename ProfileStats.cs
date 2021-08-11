// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.ProfileStats
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile
{
  public class ProfileStats
  {
    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("commandRevision")]
    public int CommandRevision { get; set; } = -1;
  }
}
