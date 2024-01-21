namespace documentManagement.models
{
    public class EducationProgram
    {
        public int id { get; set; }
        public string title { get; set; }
        public string qualification { get; set; }
        public decimal cost { get; set; }
        public string period { get; set; }

        public EducationProgram() { }

        public EducationProgram(int id, string title, string qualification, decimal cost, string period)
        {
            this.id = id;
            this.title = title;
            this.qualification = qualification;
            this.cost = cost;
            this.period = period;
        }
    }
}
