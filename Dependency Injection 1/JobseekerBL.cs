using System.Threading.Channels;

namespace DependencyInjectionExample
{ 

    // dependency injection -is gareshe
    //public class EmployeeBL
    //{


    //public EmployeeDAL employeeDAL;
    //public List<Employee> GetAllEmployees()
    //{
    //    employeeDAL = new EmployeeDAL();
    //    return employeeDAL.SelectAllEmployees();
    //}
    //}


    //constructor dependency injection



  

    //Jobseeker Business Logic
    public class JobseekerBL
    {

        public IJobseekerDAL jobseekerDAL;
        public JobseekerBL(IJobseekerDAL dal)
        {
           // this.jobseekerDAL = jobseekerDAL;
            jobseekerDAL = dal;
        }


        
        public List<Jobseeker> GetAllJobseekers()
        {
            return jobseekerDAL.SelectAllJobseekers();
        }

            
    }
   
}