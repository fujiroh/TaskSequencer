using System.Collections.Generic;

namespace TaskSequenceApp
{
    public class TaskDataProperty : ISerializable
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Priority Priority { get; private set; }
        public TaskStatus Status { get; private set; }

        public string SubTaskDataJson { get; private set; }

        public TaskDataProperty(
            int id,
            string name,
            Priority priority,
            TaskStatus status,
            IEnumerable<ISerializable> subTaskDataList)
        {
            Id = id;
            Name = name;
            Priority = priority;
            Status = status;
            SubTaskDataJson = JsonConverter<SubTaskDataProperty>.ConvertToJson(subTaskDataList);
        }
    }
}