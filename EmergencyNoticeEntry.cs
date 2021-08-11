// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.EmergencyNoticeEntry
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Content
{
  public class EmergencyNoticeEntry : BasePagesEntry
  {
    public EmergencyNoticeEntry(params PagesMessage[] messages)
      : base("emergencynotice")
    {
      this.News = new BattleRoyaleNews(Array.Empty<object>())
      {
        Messages = ((IEnumerable<PagesMessage>) messages).Select<PagesMessage, PagesMessageBase>((Func<PagesMessage, PagesMessageBase>) (x => new PagesMessage(x.Message.Title, x.Message.Body).Message)).ToList<PagesMessageBase>()
      };
    }

    [JsonProperty("news", Order = -7)]
    public BattleRoyaleNews News { get; set; }
  }
}
