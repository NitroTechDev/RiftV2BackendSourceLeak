// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Tools
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Rift.Backend.Models.Exceptions.Common;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Rift.Backend
{
  public static class Tools
  {
    public static string CreateRandomHexString()
    {
      Random random = new Random();
      string empty = string.Empty;
      for (int index = 0; index < 4; ++index)
      {
        int num = random.Next(0, int.MaxValue);
        empty += num.ToString("X8");
      }
      return empty.ToLower();
    }

    public static int GetSeasonNumber(this HttpRequest request)
    {
      if (!string.IsNullOrEmpty((string) request.Headers["User-Agent"]))
      {
        if (request.Headers["User-Agent"].ToString().Contains("Fortnite"))
        {
          try
          {
            string s = request.Headers["User-Agent"].ToString().Split("-")[1].Split(".")[0];
            return s == "Next" || s == "Cert" || s.Contains("+++Fortnite+Release") ? 2 : int.Parse(s);
          }
          catch
          {
            return 1;
          }
        }
      }
      return 1;
    }

    public static int GetCLNumber(this HttpRequest request)
    {
      if (!string.IsNullOrEmpty((string) request.Headers["User-Agent"]))
      {
        if (request.Headers["User-Agent"].ToString().Contains("Fortnite"))
        {
          try
          {
            string str1 = request.Headers["User-Agent"].ToString();
            string str2 = str1.Remove(0, str1.IndexOf("CL-", StringComparison.Ordinal)).Replace("CL-", "");
            int result;
            return int.TryParse(str2, out result) ? result : int.Parse(new string(str2.TakeWhile<char>(new Func<char, bool>(char.IsDigit)).ToArray<char>()));
          }
          catch
          {
            return 0;
          }
        }
      }
      return 0;
    }

    public static IApplicationBuilder UseEpicStatusErrors(
      this IApplicationBuilder app)
    {
      app.UseStatusCodePages((Func<StatusCodeContext, Task>) (async context =>
      {
        string str = "";
        context.HttpContext.Response.Headers["Content-Type"] = (StringValues) "application/json; charset=utf-8";
        string text;
        switch ((HttpStatusCode) context.HttpContext.Response.StatusCode)
        {
          case HttpStatusCode.NotFound:
            text = JsonConvert.SerializeObject((object) new NotFoundException());
            break;
          case HttpStatusCode.MethodNotAllowed:
            text = JsonConvert.SerializeObject((object) new MethodNotAllowedException());
            break;
          default:
            text = str;
            break;
        }
        await context.HttpContext.Response.WriteAsync(text);
      }));
      return app;
    }

    public static DateTime TrimDate(this DateTime date) => new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, date.Millisecond, date.Kind);
  }
}
