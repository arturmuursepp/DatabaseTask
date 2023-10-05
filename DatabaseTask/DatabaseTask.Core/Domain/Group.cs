namespace DatabaseTask.Core.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public bool Nursery { get; set; }
        public string Name { get; set; }
        public DateTime Vintage { get; set; }
        public Child? Children { get; set; }
    }
}
