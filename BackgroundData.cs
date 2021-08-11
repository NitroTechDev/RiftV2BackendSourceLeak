// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BackgroundData
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BackgroundData
  {
    public BackgroundData(string stage = null, string key = null)
    {
      this.Stage = stage;
      this.Key = key;
    }

    [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
    public string Stage { get; set; }

    [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
    public string Key { get; set; }

    [JsonProperty("_type")]
    public string Type => "DynamicBackground";
  }
}
