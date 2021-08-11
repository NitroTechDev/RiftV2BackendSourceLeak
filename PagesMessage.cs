// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.PagesMessage
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class PagesMessage
  {
    [JsonProperty("_type")]
    public string Type => "CommonUI Simple Message";

    [JsonProperty("message")]
    public PagesMessageBase Message { get; set; }

    public PagesMessage(string title, string body, string image = null, string adspace = null) => this.Message = new PagesMessageBase(title, body, image, adspace);
  }
}
