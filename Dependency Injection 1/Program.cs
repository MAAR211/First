namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            JobseekerBL jobseekerBL = new JobseekerBL(new JobseekerDAL());
            List<Jobseeker> ListJobseekere = jobseekerBL.GetAllJobseekers();
            foreach (Jobseeker emp in ListJobseekere)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Email = {2}", emp.ID, emp.Name, emp.Email);
            }
            Console.ReadKey();
        }
    }
}