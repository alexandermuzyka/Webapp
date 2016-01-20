using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AbstractWorker;
using UI.ConcreteWorker;
using UI.Domain; 

namespace UI.Domain
{
  public class ConcreteRepository
    {
      public virtual IQueryable<Worker> Workers { get; set; }
   
  }

}
