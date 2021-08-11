// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Fortnite.InvalidParameterException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.Fortnite
{
  internal class InvalidParameterException : BaseException
  {
    public InvalidParameterException()
      : base(16040, "itemIds and itemFavStatus must match in size")
    {
      this.Status = 400;
    }
  }
}
