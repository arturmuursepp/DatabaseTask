namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool InQueue { get; set; }
    }
}
