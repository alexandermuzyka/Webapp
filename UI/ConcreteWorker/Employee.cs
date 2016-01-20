using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AbstractWorker;

namespace UI.ConcreteWorker
{
   public class Employee:Worker
    {
       public Employee() { }
       public Employee(string Name, string data) 
        {
            this.Start_Time = Convert.ToDateTime(data);
            this.Name = Name.ToUpper();
            this.Start_Salary = 1000.0M;
        }
        ~Employee() { }

       public override decimal Current_Salary()
        {
            int Year_Total = Convert.ToInt32((DateTime.Now - this.Start_Time).TotalDays / 30 / 12);
            if (Year_Total > 10) Year_Total = 10;
            return (this.Start_Salary + Convert.ToDecimal(0.03 * Year_Total * Convert.ToDouble(this.Start_Salary)));
        }

       public override void Salary_atRandomTime()
       {
           string time;
           Console.WriteLine("  Please, input the time period to calculate the sale:   ");
           time = Console.ReadLine();
           try { 

           if (Convert.ToDateTime(time).Year < this.Start_Time.Year)
           {
               Console.WriteLine("  The fixed time should not be less then the start time! Please, try again.");
               Salary_atRandomTime();           
           }
           
           else
           {
               int Year_Count = Convert.ToInt32((Convert.ToDateTime(time) - this.Start_Time).TotalDays / 30 / 12);
               if (Year_Count > 10) Year_Count = 10;
               decimal Salary = this.Start_Salary + Convert.ToDecimal(0.03 * Year_Count * Convert.ToDouble(this.Start_Salary));
               Console.WriteLine("Start_Time: {0} | Start Salary: {1} | Salaryattime: {2} | Current Salary: {3}", this.Start_Time.ToString("yyyy-MM-dd"), this.Start_Salary.ToString("c"), Salary.ToString("c"), this.Current_Salary().ToString("c"));
           }
           }
           catch (FormatException ) { Console.WriteLine("               Not correct format\n\n");Salary_atRandomTime();  }
       }

        
    }
    
}
