// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BasePagesEntry
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Content
{
  public class BasePagesEntry
  {
    [JsonProperty("_title", Order = -8)]
    public string Title { get; set; }

    [JsonProperty("_activeDate", Order = -5)]
    public DateTime ActiveDate => DateTime.UtcNow.AddMonths(-12);

    [JsonProperty("lastModified", Order = -4)]
    public DateTime LastModified { get; set; }

    [JsonProperty("_locale", Order = -3)]
    public string Locale => "en-US";

    public BasePagesEntry(string title, DateTime? lastModified = null)
    {
      this.Title = title;
      this.LastModified = lastModified ?? DateTime.UtcNow;
    }
  }
}
