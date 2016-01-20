using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Domain;
using UI.AbstractWorker;
using UI.ConcreteWorker;

namespace UI
{
   public class Managing
   {
      Worker worker;
      public ConcreteRepository T;
        public Managing(ConcreteRepository worker_repository) 
        {
            T = worker_repository;
        }

        public UI.AbstractWorker.Worker Worker
        {
            get
            {
               // throw new System.NotImplementedException();
                return worker;
            }
            set
            {
            }
        }

        public UI.Domain.ConcreteRepository ConcreteRepository
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

       /// <summary>
       /// /////////////////////////////////////////////
       /// </summary>
        public void Show() 
        {
            foreach (var n in T.Workers)
            {
                n.Show();
               // Console.WriteLine();
            }
        }
       /// <summary>
       /// //////////////////////////////////////////////
       /// </summary>
        public void Total_Salary_Company() 
        {
            decimal Total_Salary = 0.0M;
            foreach (var p in T.Workers)
            {
                Total_Salary += p.Current_Salary();
            }

            Console.WriteLine("Total_Salary: " + Total_Salary.ToString("c"));  
        }

       /// <summary>
       /// Function is determined for research person and calculate its salary for any period along the time he work.
       /// </summary>
       /// 
        public void Run()
        {
            worker = null;
            string Name;
            Console.WriteLine("Please, enter the name of person we should find: ");
            Name = Console.ReadLine().ToUpper();
            foreach (var p in T.Workers) 
            {
                if (p.Name == Name)
                {
                    worker = p; Console.WriteLine("Research success! Researched person found."); break ;
                }   
            }

            if (worker == null)
            {
                Console.WriteLine("Something is wrong! Please, try again.");
                Run();
                return;
            }

            worker.Show();
            worker.Salary_atRandomTime();
        }
    }
}
