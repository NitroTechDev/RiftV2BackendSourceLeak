// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.OAuth.InvalidClientException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.OAuth
{
  internal class InvalidClientException : BaseException
  {
    public InvalidClientException()
      : base(1011, "It appears that your Authorization header may be invalid or not present, please verify that you are sending the correct headers.")
    {
      this.Status = 400;
    }
  }
}
