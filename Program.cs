// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Program
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Rift.Backend
{
  public class Program
  {
    public static readonly Dictionary<string, object> CosmeticLoadout = new Dictionary<string, object>()
    {
      {
        "character",
        (object) "AthenaCharacter:cid_random"
      },
      {
        "backpack",
        (object) ""
      },
      {
        "pickaxe",
        (object) "AthenaPickaxe:defaultpickaxe"
      },
      {
        "glider",
        (object) "AthenaGlider:defaultglider"
      },
      {
        "skydivecontrail",
        (object) ""
      },
      {
        "loadingscreen",
        (object) ""
      },
      {
        "musicpack",
        (object) ""
      },
      {
        "dance",
        (object) new string[6]
        {
          "AthenaDance:eid_dancemoves",
          "",
          "",
          "",
          "",
          ""
        }
      },
      {
        "itemwrap",
        (object) new string[7]{ "", "", "", "", "", "", "" }
      }
    };
    public static readonly string[] WhitelistedCosmetics = new string[8]
    {
      "AthenaCharacter:cid_random",
      "AthenaPickaxe:defaultpickaxe",
      "AthenaPickaxe:pickaxe_random",
      "AthenaGlider:defaultglider",
      "AthenaGlider:glider_random",
      "AthenaDance:eid_dancemoves",
      "AthenaDance:eid_wir",
      "AthenaDance:eid_boogiedown"
    };

    public static string Id { get; set; }

    public static string DisplayName { get; set; }

    public static string ClientId { get; set; }

    public static int AthenaRvn { get; set; }

    public static int CommonCoreRvn { get; set; }

    public static void Main(string[] args) => Program.CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureLogging((Action<ILoggingBuilder>) (logging => logging.ClearProviders())).ConfigureWebHostDefaults((Action<IWebHostBuilder>) (webBuilder =>
    {
      webBuilder.UseUrls("http://*:8010");
      webBuilder.UseStartup<Startup>();
    }));
  }
}
