// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Common.UnhandledErrorException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.Common
{
  internal class UnhandledErrorException : BaseException
  {
    public UnhandledErrorException(string message)
      : base(1012, "Sorry, an error occurred and we were unable to resolve it. Error: {0}", message)
    {
      this.Status = 500;
    }
  }
}
