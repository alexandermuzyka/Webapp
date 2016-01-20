using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.AbstractWorker
{
   public abstract class Worker
    {
      public string Name { get; set; }
      public  DateTime Start_Time { get; set; }
      public  decimal Start_Salary{get;set;}
      public  void Show()
      {
          Console.WriteLine("Worker Name: {0,10} | Start_Time: {1} | Start Salary: {2} | Current Salary: {3}", this.Name, this.Start_Time.ToString("yyyy-MM-dd"), this.Start_Salary, this.Current_Salary());
      }
      public abstract decimal Current_Salary();
      public abstract void Salary_atRandomTime();
    }
}
