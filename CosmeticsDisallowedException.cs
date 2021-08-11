// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Failsafe.CosmeticsDisallowedException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.Failsafe
{
  internal class CosmeticsDisallowedException : BaseException
  {
    public CosmeticsDisallowedException()
      : base(19002, "Rift does not natively support cosmetics due to legal and ethical concerns.")
    {
      this.Status = 403;
    }
  }
}
