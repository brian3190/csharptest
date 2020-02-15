using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semaphores
{
  class Program
  {
    static SemaphoreSlim semaslim = new SemaphoreSlim(3);

    static void Main(string[] args)
    {
      for(int i=0; i<10; i++)
      {
        new Thread(EnterSemaphore).Start(i);
      }
    }

    private static void EnterSemaphore(object id)
    {
      Console.WriteLine(id + " is waiting to be part of the club")
      semaslim.Wait();
      Console.WriteLine(id + "part of the club");
      Thread.Sleep(1000 / (int)id);
      Console.WriteLine(id + " left the club");
    }
  }
}
