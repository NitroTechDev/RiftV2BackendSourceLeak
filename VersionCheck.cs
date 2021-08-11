// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Fortnite.VersionCheck
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Fortnite
{
  public class VersionCheck
  {
    [JsonProperty("type")]
    public string Type { get; set; }

    public VersionCheck(string type) => this.Type = type;
  }
}
