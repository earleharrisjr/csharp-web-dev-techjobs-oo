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
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Id == job2.Id);
        }
        [TestMethod]
        public void TestToString()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            string testJobOutput = $"\nID: {job1.Id}" +
            $"\nName: {job1.Name}\nEmployer: {job1.EmployerName.Value}" +
            $"\nLocation: {job1.EmployerLocation.Value}" +
            $"\nPosition Type: {job1.JobType.Value}" +
            $"\nCore Competency: {job1.JobCoreCompetency.Value}";

            Assert.IsTrue(job1.ToString() == testJobOutput);
        }

    }
}
