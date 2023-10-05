namespace DatabaseTask.Core.Domain
{
    public class Absence
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public IEnumerable<Child> Children { get; set; } = new List<Child>();
    }
}
