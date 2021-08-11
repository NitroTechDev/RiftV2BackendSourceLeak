// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Storefront.Storefront
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Storefront
{
  public class Storefront
  {
    public Storefront(string name) => this.Name = name;

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("catalogEntries")]
    public object[] CatalogEntries => Array.Empty<object>();
  }
}
