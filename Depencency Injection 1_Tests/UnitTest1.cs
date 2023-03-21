using DependencyInjectionExample;
using FakeItEasy;
namespace Depencency_Injection_1_Tests
{


    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class JobseekerBLTests
        {
            [Test]
            public void GetAllEmployees_ReturnsListOfJobseekers()
            {
                // Arrange

                // Create a fake instance of the IJobseekerDAL interface using FakeItEasy
                var jobseekerDAL = A.Fake<IJobseekerDAL>();

                // Create an instance of the JobseekerBL class, passing in the fake IJobseekerDAL instance
                var jobseekerBL = new JobseekerBL(jobseekerDAL);

                // Create some fake Jobseeker objects to be returned by the fake SelectAllJobseekers method
                var fakeJobseekers = new List<Jobseeker>
        {
            new Jobseeker { ID = 1, Name = "John Doe", Email = "johndoe@example.com" },
            new Jobseeker { ID = 2, Name = "Jane Smith", Email = "janesmith@example.com" },
            new Jobseeker { ID = 3, Name = "Bob Johnson", Email = "bobjohnson@example.com" }
        };

                // Set up the fake SelectAllJobseekers method to return the fake Jobseeker objects
                A.CallTo(() => jobseekerDAL.SelectAllJobseekers()).Returns(fakeJobseekers);

                // Act

                // Call the GetAllEmployees method on the JobseekerBL instance
                var result = jobseekerBL.GetAllJobseekers();

                // Assert

                // Check that the result is a List<Jobseeker> object
                Assert.IsInstanceOf<List<Jobseeker>>(result);

                // Check that the number of items in the result is the same as the number of fake Jobseeker objects
                Assert.AreEqual(fakeJobseekers.Count, result.Count);

                // Check that the values of the properties of the first Jobseeker object in the result match the values of the properties of the first fake Jobseeker object
                Assert.AreEqual(fakeJobseekers[0].Name, result[0].Name);
                Assert.AreEqual(fakeJobseekers[0].Email, result[0].Email);
                Assert.AreEqual(fakeJobseekers[0].ID, result[0].ID);

                // Check that the values of the properties of the second Jobseeker object in the result match the values of the properties of the second fake Jobseeker object
                Assert.AreEqual(fakeJobseekers[1].Name, result[1].Name);
                Assert.AreEqual(fakeJobseekers[1].Email, result[1].Email);
                Assert.AreEqual(fakeJobseekers[1].ID, result[1].ID);

                // Check that the values of the properties of the third Jobseeker object in the result match the values of the properties of the third fake Jobseeker object
                Assert.AreEqual(fakeJobseekers[2].Name, result[2].Name);
                Assert.AreEqual(fakeJobseekers[2].Email, result[2].Email);
                Assert.AreEqual(fakeJobseekers[2].ID, result[2].ID);
            }
        }


    }
}