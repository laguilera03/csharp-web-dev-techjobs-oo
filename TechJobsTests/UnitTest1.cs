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

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job aJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(aJob.Name.ToString(), "Product tester");
            Assert.AreEqual(aJob.EmployerName.ToString(), "ACME");
            Assert.AreEqual(aJob.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(aJob.JobType.ToString(), "Quality control");
            Assert.AreEqual(aJob.JobCoreCompetency.ToString(), "Persistence");
        }

        //public void TestJobsForEquality()
        //{
        //    Job aJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Job anotherJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Assert.AreEqual(Equals(aJob), Equals(anotherJob));
        //}

        [TestMethod]
        public void JobTests()
        {
            Job aJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string obj = aJob.ToString();
            Assert.AreEqual(obj[0], '_');
            Assert.AreEqual(obj[obj.Length - 1], '_');
        }

        [TestMethod]
        public void JobFieldTests()
        {
            Job aJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(aJob.ToString(), "_\nID: " + aJob.Id.ToString() + "\nName: " + aJob.Name.ToString() + "\nEmployer: " + aJob.EmployerName.ToString() + "\nLocation: " + aJob.EmployerLocation.ToString() + "\nPosition Type: " + aJob.JobType.ToString() + "\nCore Competency: " + aJob.JobCoreCompetency.ToString() + "\n_");
        }

        [TestMethod]
        public void JobEmptyFieldTests()
        {
            string emptyParameter = "Data not available";
            Job aJob = new Job("Product tester", new Employer("ACME"), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual(aJob.ToString(), "_\nID: " + aJob.Id.ToString() + "\nName: " + aJob.Name.ToString() + "\nEmployer: " + aJob.EmployerName.ToString() + "\nLocation: " + emptyParameter + "\nPosition Type: " + emptyParameter + "\nCore Competency: " + emptyParameter + "\n_");
        }

        [TestMethod]
        public void JobAllEmptyFieldTests()
        {
            string emptyParameter = "Data not available";
            string oopsLine = "\nOOPS! This job does not seem to exist.";
            Job aJob = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual(aJob.ToString(), "_\nID: " + aJob.Id.ToString() + "\nName: " + emptyParameter + "\nEmployer: " + emptyParameter + "\nLocation: " + emptyParameter + "\nPosition Type: " + emptyParameter + "\nCore Competency: " + emptyParameter + oopsLine + "\n_");
        }
    }
}