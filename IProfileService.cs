// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Services.IProfileService
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Services
{
  public interface IProfileService
  {
    Rift.Backend.Models.Profile.Profile GenerateAthenaProfile(
      string id,
      int seasonNumber,
      string profileId = "athena");

    Rift.Backend.Models.Profile.Profile GenerateCommonCoreProfile(
      string id,
      string profileId = "common_core");

    Rift.Backend.Models.Profile.Profile GenerateBlankProfile(string id, string profileId);
  }
}
