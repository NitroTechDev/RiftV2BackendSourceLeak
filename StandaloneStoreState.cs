// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.States.StandaloneStoreState
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Calendar.States
{
  public class StandaloneStoreState
  {
    [JsonProperty("activePurchaseLimitingEventIds")]
    public string[] ActivePurchaseLimitingEventIds => Array.Empty<string>();

    [JsonProperty("storefront")]
    public object Storefront => new object();

    [JsonProperty("rmtPromotionConfig")]
    public string[] RMTPromotionConfig => Array.Empty<string>();

    [JsonProperty("storeEnd")]
    public DateTime StoreEnd => DateTime.MinValue;
  }
}
