using System.Threading.Channels;

namespace DependencyInjectionExample
{
    // dependency injection -is gareshe
    //public class EmployeeDAL
    //{


    //    public List<Employee> SelectAllEmployees()
    //    {
    //        List<Employee> ListEmployees = new List<Employee>();
    //        //Get the Employees from the Database
    //        //for now we are hard coded the employees
    //        ListEmployees.Add(new Employee() { ID = 1, Name = "Pranaya", Department = "IT" });
    //        ListEmployees.Add(new Employee() { ID = 2, Name = "Kumar", Department = "HR" });
    //        ListEmployees.Add(new Employee() { ID = 3, Name = "Rout", Department = "Payroll" });
    //        return ListEmployees;
    //    }
    //}






    public interface IJobseekerDAL
    {
        List<Jobseeker> SelectAllJobseekers();
    }





    //IJobseekerDAL - interfeisis implementacia am klasit - JobseekerDAL
    // SelectAllJobseekers - metodis implementacia, es unda sheicvalos rom bazidan daabrunos info

    //Jobseeker Data Access Layer
    public class JobseekerDAL : IJobseekerDAL
    { 
        public List<Jobseeker> SelectAllJobseekers()
        {
            List<Jobseeker> jobseekerInfo = new List<Jobseeker>();

            //bazian wamoigos info, axla isea gawerili

            jobseekerInfo.Add(new Jobseeker() { ID = 1, Name = "Name1", Email = "test1@hr.ge" });
            jobseekerInfo.Add(new Jobseeker() { ID = 2, Name = "Name2", Email = "test2@hr.ge" });
            jobseekerInfo.Add(new Jobseeker() { ID = 3, Name = "Name3", Email = "test3@hr.ge" });
            return jobseekerInfo; 
        }

    }


}