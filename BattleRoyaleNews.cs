// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNews
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNews
  {
    public BattleRoyaleNews(params object[] motds)
    {
      this.Messages = ((IEnumerable<object>) motds).Select<object, PagesMessageBase>((Func<object, PagesMessageBase>) (x =>
      {
        BattleRoyaleNewsMOTD battleRoyaleNewsMotd = (BattleRoyaleNewsMOTD) x;
        return new PagesMessage(battleRoyaleNewsMotd.Title, battleRoyaleNewsMotd.Body, battleRoyaleNewsMotd.TileImage).Message;
      })).Where<PagesMessageBase>((Func<PagesMessageBase, bool>) (x => x != null)).ToList<PagesMessageBase>();
      this.MOTDS = ((IEnumerable<object>) motds).ToList<object>();
    }

    [JsonProperty("messages")]
    public List<PagesMessageBase> Messages { get; set; }

    [JsonProperty("motds")]
    public List<object> MOTDS { get; set; }
  }
}
