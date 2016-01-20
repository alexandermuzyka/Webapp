using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI.AbstractWorker;
using UI.ConcreteWorker;
using UI.Domain;
using Moq;
using System.Collections.Generic;
using System.Linq;
using UI;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Worker emp = new Employee("Alexander", "01/08/2015");
            Worker mang = new Manager("Sergey", "01/08/2015", 1);
            Worker sal_s = new Sales("Oleksey", "01/08/2015",2,3);
        }
    }


   [TestClass]
    public class UnitTest2
    {
       Mock<ConcreteRepository> mock = new Mock<ConcreteRepository>();
           
         [TestMethod]
        public void TestMethod2(){
        mock.Setup(m => m.Workers).Returns(new List<Worker> {
          new Employee ( "Football", "01/08/2015" ),
          new  Manager("Surf board", "01/08/2015",1),
          new Sales ("Running shoes", "01/08/2015",2,3)
        }.AsQueryable());

        foreach (var p in mock.Object.Workers)
         p.Show();

        Managing mang = new Managing(mock.Object);
        mang.Total_Salary_Company();

         }


         [TestMethod]
         public void TestMethod3() 
         {
             ConcreteRepository concrep = new ConcreteRepository();
             concrep.Workers = new List<Worker>() {
          new Employee ( "Alexander", "01/08/2015" ),
          new  Manager("Sergey", "01/08/2015",2),
          new Sales ("Oleg", "01/08/2015",2,3) 
            }.AsQueryable();

             Managing mang = new Managing(concrep);
             mang.Total_Salary_Company();
         }
    }

}
