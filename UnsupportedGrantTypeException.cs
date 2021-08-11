// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.OAuth.UnsupportedGrantTypeException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.OAuth
{
  internal class UnsupportedGrantTypeException : BaseException
  {
    public UnsupportedGrantTypeException(string grantType)
      : base(1013, "Unsupported grant type: " + grantType)
    {
      this.Status = 400;
    }
  }
}
