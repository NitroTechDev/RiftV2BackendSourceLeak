// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Storefront.Catalog
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Storefront
{
  public class Catalog
  {
    public Catalog() => this.Storefronts = new List<Rift.Backend.Models.Storefront.Storefront>()
    {
      new Rift.Backend.Models.Storefront.Storefront("BRDailyStorefront"),
      new Rift.Backend.Models.Storefront.Storefront("BRWeeklyStorefront")
    };

    [JsonProperty("refreshIntervalHrs")]
    public int RefreshIntervalHrs => 24;

    [JsonProperty("dailyPurchaseHrs")]
    public int DailyPurchaseHrs => 24;

    [JsonProperty("expiration")]
    public DateTime Expiration => DateTime.MaxValue;

    [JsonProperty("storefronts")]
    public List<Rift.Backend.Models.Storefront.Storefront> Storefronts { get; set; }
  }
}
