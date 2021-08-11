// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Lightswitch.LauncherInfo
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Lightswitch
{
  public class LauncherInfo
  {
    [JsonProperty("appName")]
    public string AppName => "Fortnite";

    [JsonProperty("catalogItemId")]
    public string CatalogItemId => "4fe75bbc5a674f4f9b356b5c90567da5";

    [JsonProperty("namespace")]
    public string Namespace => "fn";
  }
}
