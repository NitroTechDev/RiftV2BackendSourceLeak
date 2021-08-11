// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNewsEntry
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNewsEntry : BasePagesEntry
  {
    public BattleRoyaleNewsEntry(params object[] motds)
      : base("battleroyalenews")
    {
      this.News = new BattleRoyaleNews(motds);
    }

    [JsonProperty("news", Order = -7)]
    public BattleRoyaleNews News { get; set; }
  }
}
