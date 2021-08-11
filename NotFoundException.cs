// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Common.NotFoundException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.Common
{
  internal class NotFoundException : BaseException
  {
    public NotFoundException()
      : base(1004, "Sorry the resource you were trying to find could not be found")
    {
      this.Status = 404;
    }
  }
}
