using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProgram
{
   public class Worker
    {
        //public Guid Id { get; private set; }
        public string FIO { get; set; }
        public string Post { get; set; }
        public bool isComing { get; set; }
        public Worker()
        {
            isComing = false;
        }
    }
    
}
