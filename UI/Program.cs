using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Domain;
using UI.AbstractWorker;
using UI.ConcreteWorker;
using System.Windows;



namespace UI
{
    class Program
    {
        public Managing Managing
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        static void Main(string[] args)
        {
          ConcreteRepository concrep = new ConcreteRepository();
          concrep.Workers = new List<Worker>() 
          {
          new Employee ( "Alexander", "01/01/2005" ),
          new Employee("Igor", "01/01/2010"),
          new Employee("Vasuliy", "01/01/2004"),
          new Employee("Peter", "01/01/2013"),
          new Employee("Petya", "01/01/2008"),
          new Employee("Alexey", "05/08/2011"),
          new Employee("Svyatoslav", "13/02/2001"),
          new Manager("Anton", "12/12/2010",2),
          new Manager("Olga","13/05/2010",3),
          new Manager("Svetlana", "05/05/2005",2),
          new Sales ("Oleg", "06/12/2005", 1,2) ,
          new Sales ("Irina", "05/08/2008",2,3),
          new Sales ("Olena", "01/01/2009",1,3)
          }.AsQueryable();
            
       Managing mang = new Managing(concrep);
       mang.Show();
       mang.Total_Salary_Company();
       mang.Run();
       Console.Read();
        }

       
    }

}
