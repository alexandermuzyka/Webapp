using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AbstractWorker;

namespace UI.ConcreteWorker
{
   public class Manager:Worker
    {
       public int employee_count { get; set; }
       public Manager() { }
       public Manager(String Name, string data, int emp_count)
       {
           this.employee_count = emp_count;
           this.Start_Time = Convert.ToDateTime(data);
           this.Name = Name.ToUpper();
           this.Start_Salary = 1000.0M;
       }

       public override decimal Current_Salary()
       {
           int Year_Total = Convert.ToInt32((DateTime.Now - this.Start_Time).TotalDays / 30 / 12);
           if (Year_Total > 8) Year_Total = 8;
           return (this.Start_Salary + Convert.ToDecimal(0.05 * Year_Total * Convert.ToDouble(this.Start_Salary)) + Convert.ToDecimal(Convert.ToDouble(this.Start_Salary) * this.employee_count *Year_Total* 0.005));
       }

       public override void Salary_atRandomTime()
       {
           string time;
           Console.WriteLine("Please, input the time period to calculate the sale:   ");
           time = Console.ReadLine();
           try
           {
               if (Convert.ToDateTime(time).Year < this.Start_Time.Year)
               {
                   Console.WriteLine("The fixed time should not be less then the start time! Please, try again.");
                   Salary_atRandomTime();
               }
               else
               {
                   int Year_Count = Convert.ToInt32((Convert.ToDateTime(time) - this.Start_Time).TotalDays / 30 / 12);
                   if (Year_Count > 8) Year_Count = 8;
                   decimal Salary = this.Start_Salary + 
                       Convert.ToDecimal(0.05 * Year_Count * Convert.ToDouble(this.Start_Salary)) + 
                       Convert.ToDecimal(Convert.ToDouble(this.Start_Salary) * this.employee_count * Year_Count * 0.005);
                   Console.WriteLine("Start Salary: {0} | Salaryattime: {1} | Current Salary: {2}", this.Start_Salary.ToString("c"), Salary.ToString("c"), this.Current_Salary().ToString("c"));
               }
           }
           catch (FormatException) { Console.WriteLine("Not correct format"); Salary_atRandomTime(); }
       }

        ~Manager() { }
    }
}
