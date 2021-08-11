// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.Changes.McpStatModified
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile.Changes
{
  public class McpStatModified : McpChange
  {
    [JsonProperty("name")]
    public string Stat { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }

    public McpStatModified(string stat, object value)
      : base("statModified")
    {
      this.Stat = stat;
      this.Value = value;
    }
  }
}
