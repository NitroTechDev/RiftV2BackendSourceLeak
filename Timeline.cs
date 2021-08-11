// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.Timeline
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Calendar
{
  public class Timeline
  {
    [JsonProperty("channels")]
    public Dictionary<string, TimelineChannel> Channels { get; set; }

    [JsonProperty("currentTime")]
    public DateTime CurrentTime => DateTime.UtcNow;

    [JsonProperty("cacheIntervalMins")]
    public double CacheIntervalMinutes => 15.0;
  }
}
