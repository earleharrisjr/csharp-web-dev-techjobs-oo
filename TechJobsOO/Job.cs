using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; } 
        public Employer EmployerName { get; set; } 
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string jobOutput;
            string nameStr = Name;
            string employerNameStr = EmployerName.Value;
            string employerLocationStr = EmployerLocation.Value;
            string jobTypeStr = JobType.Value;
            string jobCoreCompetencyStr = JobCoreCompetency.Value;

            if (nameStr == "")
            {
                nameStr = "Data not available";
            }

            if (employerNameStr == "")
            {
                employerNameStr = "Data not available";
            }

            if (employerLocationStr == "")
            {
                employerLocationStr = "Data not available";
            }

            if (jobTypeStr == "")
            {
                jobTypeStr = "Data not available";
            }

            if (jobCoreCompetencyStr == "")
            {
                jobCoreCompetencyStr = "Data not available";
            }

            jobOutput = $"\nID: {Id}" +
                        $"\nName: {nameStr}\nEmployer: {employerNameStr}" +
                        $"\nLocation: {employerLocationStr}" +
                        $"\nPosition Type: {jobTypeStr}" +
                        $"\nCore Competency: {jobCoreCompetencyStr}";
            
            return jobOutput;


        }
    }
}
