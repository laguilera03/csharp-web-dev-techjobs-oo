using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job firstJob = new Job();
            Job secondJob = new Job();
            Assert.IsFalse(firstJob == secondJob);
        }

        public void TestJobConstructorSetsAllFields()
        {
            Job aJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(aJob.Name, "Product tester");
            Assert.AreEqual(aJob.EmployerName, "ACME");
            Assert.AreEqual(aJob.EmployerLocation, "Desert");
            Assert.AreEqual(aJob.JobType, "Quality control");
            Assert.AreEqual(aJob.JobCoreCompetency, "Persistence");
        }

        //public void TestJobsForEquality()
        //{
        //    Job aJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Job anotherJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Assert.AreEqual(Equals(aJob), Equals(anotherJob));
        //}
    }
}