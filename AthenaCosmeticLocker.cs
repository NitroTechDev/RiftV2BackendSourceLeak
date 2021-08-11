// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Fortnite.AthenaCosmeticLocker
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Fortnite
{
  public class AthenaCosmeticLocker
  {
    [JsonProperty("locker_slots_data")]
    public AthenaLockerSlotsData LockerSlotsData { get; set; }

    [JsonProperty("use_count")]
    public int UseCount => 0;

    [JsonProperty("banner_icon_template")]
    public string BannerIcon { get; set; }

    [JsonProperty("banner_color_template")]
    public string BannerColor { get; set; }

    [JsonProperty("locker_name")]
    public string LockerName { get; set; }

    [JsonProperty("item_seen")]
    public bool ItemSeen => false;

    [JsonProperty("favorite")]
    public bool Favorite => false;
  }
}
