namespace Boss_Project
{
    public class Vacancy
    {
        public string Category { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public string Experience { get; set; }
        public string RequiredDegree { get; set; }

        public override string ToString()
        {
            return $@"
Category : {Category}
Minimum Salary : {MinSalary}
Maximum Salary : {MaxSalary}
Experience : {Experience}
Required Degree For Job : {RequiredDegree}";
        }
    }
}
