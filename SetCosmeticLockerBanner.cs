// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Commands.Cosmetics.SetCosmeticLockerBanner
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Commands.Cosmetics
{
  public class SetCosmeticLockerBanner
  {
    [JsonProperty("lockerItem")]
    [JsonRequired]
    public string LockerItem { get; set; }

    [JsonProperty("bannerColorTemplateName")]
    [JsonRequired]
    public string BannerColorTemplateName { get; set; }

    [JsonProperty("bannerIconTemplateName")]
    [JsonRequired]
    public string BannerIconTemplateName { get; set; }
  }
}
