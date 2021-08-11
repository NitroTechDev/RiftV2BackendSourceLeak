// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.Background
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Content
{
  public class Background
  {
    public Background(params BackgroundData[] backgrounds) => this.Backgrounds = ((IEnumerable<BackgroundData>) backgrounds).Select<BackgroundData, BackgroundData>((Func<BackgroundData, BackgroundData>) (x => new BackgroundData(x.Stage, x.Key))).ToList<BackgroundData>();

    [JsonProperty("backgrounds", Order = -7)]
    public List<BackgroundData> Backgrounds { get; set; }

    [JsonProperty("_type")]
    public string Type => "DynamicBackgroundList";
  }
}
