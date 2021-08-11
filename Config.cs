﻿// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Cloudstorage.Config
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Cloudstorage
{
  public class Config
  {
    public Config() => this.Transports = new Dictionary<string, ConfigTransport>()
    {
      ["McpProxyTransport"] = new ConfigTransport("McpProxyTransport", "ProxyStreamingFile", false, 10),
      ["McpSignatoryTransport"] = new ConfigTransport("McpSignatoryTransport", "ProxySignatory", false, 20),
      ["DssDirectTransport"] = new ConfigTransport("DssDirectTransport", "DirectDss", false, 30)
    };

    [JsonProperty("lastUpdated")]
    public DateTime LastUpdated => DateTime.UtcNow;

    [JsonProperty("disableV2")]
    public bool DisableV2 => true;

    [JsonProperty("isAuthenticated")]
    public bool IsAuthenticated => true;

    [JsonProperty("transports")]
    public string EnumerateFilesPath => "/api/cloudstorage/system";

    [JsonProperty("enumerateFilesPath")]
    public Dictionary<string, ConfigTransport> Transports { get; set; }
  }
}
