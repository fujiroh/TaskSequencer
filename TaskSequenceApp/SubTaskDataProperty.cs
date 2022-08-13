namespace TaskSequenceApp
{
    public class SubTaskDataProperty : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public SubTaskDataProperty(int id, string name, bool isCompleted)
        {
            Id = id;
            Name = name;
            IsCompleted = isCompleted;
        }
    }
}