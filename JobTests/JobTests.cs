using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();   
            Job job2 = new Job();   
            Assert.AreEqual(job1.Id, job2.Id, 1);  
        }

        //FULL  BELOW
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester"
                && job1.EmployerName.Value == "ACME"
                && job1.EmployerLocation.Value == "Desert"
                && job1.JobType.Value == "Quality control"
                && job1.JobCoreCompetency.Value == "Persistence");
                    }
    }
}
