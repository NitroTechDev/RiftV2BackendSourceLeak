// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Cloudstorage.ConfigTransport
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Cloudstorage
{
  public class ConfigTransport
  {
    public ConfigTransport(string name, string type, bool isEnabled, int priority)
    {
      this.Name = name;
      this.Type = type;
      this.IsEnabled = isEnabled;
      this.IsRequired = isEnabled;
      this.IsPrimary = isEnabled;
      this.Priority = priority;
    }

    public string Name { get; set; }

    public string Type { get; set; }

    public string AppName => "Fortnite";

    public bool IsEnabled { get; set; }

    public bool IsRequired { get; set; }

    public bool IsPrimary { get; set; }

    public int TimeoutSeconds => 30;

    public int Priority { get; set; }
  }
}
