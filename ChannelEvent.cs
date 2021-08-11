// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.ChannelEvent
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Calendar
{
  public class ChannelEvent
  {
    public ChannelEvent(string eventType) => this.EventType = eventType;

    [JsonProperty("eventType")]
    public string EventType { get; set; }

    [JsonProperty("activeUntil")]
    public DateTime ActiveUntil => DateTime.MaxValue;

    [JsonProperty("activeSince")]
    public DateTime ActiveSince => DateTime.UtcNow;
  }
}
