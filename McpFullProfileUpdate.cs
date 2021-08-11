﻿// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.Changes.McpFullProfileUpdate
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile.Changes
{
  public class McpFullProfileUpdate : McpChange
  {
    public McpFullProfileUpdate(Rift.Backend.Models.Profile.Profile profile)
      : base("fullProfileUpdate")
    {
      this.Profile = profile;
    }

    [JsonProperty("profile")]
    public Rift.Backend.Models.Profile.Profile Profile { get; set; }
  }
}
