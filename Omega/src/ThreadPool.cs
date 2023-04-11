using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Omega
{
    public  class ThreadPool
    {
        public List<Thread> threads = new List<Thread>();
        
        public void Add(Thread thread) {
            threads.Add(thread);
            
        }
        public void Execute(){
            foreach(Thread thread in threads)
            {
                thread.Start();
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
                
            }
            threads.Clear();
        }
       

    }
}
