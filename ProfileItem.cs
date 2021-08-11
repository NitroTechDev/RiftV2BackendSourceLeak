// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.ProfileItem
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile
{
  public class ProfileItem
  {
    [JsonProperty("templateId")]
    public string TemplateId { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    public ProfileItem(string templateId, object attributes = null, int quantity = 1)
    {
      this.TemplateId = templateId;
      this.Attributes = attributes ?? (object) new ItemAttributes();
      this.Quantity = quantity;
    }
  }
}
