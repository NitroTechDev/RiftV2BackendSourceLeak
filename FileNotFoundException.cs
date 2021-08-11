// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Cloudstorage.FileNotFoundException
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1C39EC91-1E22-40E6-8347-4D558F748874
// Assembly location: C:\Users\ca297\Desktop\Rift\Shard.dll

namespace Rift.Backend.Models.Exceptions.Cloudstorage
{
  internal class FileNotFoundException : BaseException
  {
    public FileNotFoundException(string file)
      : base(12004, "Sorry, we couldn't find a system file for {0}", file)
    {
      this.Status = 404;
    }
  }
}
