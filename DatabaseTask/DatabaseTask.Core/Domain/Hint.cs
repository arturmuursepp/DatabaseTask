namespace DatabaseTask.Core.Domain
{
    public class Hint
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public IEnumerable<Child> Children { get; set; } = new List<Child>();

    }
}
