using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TaskSequenceApp
{
    [DataContract]
    public class TaskData : IEquatable<TaskData>, ICreatableJsonData
    {
        private readonly TaskStatus _taskStatus;
        private readonly Priority _priority;

        private readonly int _id;
        private readonly string _name;
        private readonly IList<SubTaskData> _subTaskDataList;

        public string Name { get; set; }
        public int Id { get; set; }
        public Priority Priority => _priority;
        public TaskStatus Status => _taskStatus;
        public IEnumerable<SubTaskData> SubTaskDataListDataList => _subTaskDataList;

        public TaskData(string name)
        {
            _taskStatus = TaskStatus.Do;
            _priority = Priority.Medium;

            // TODO:IDを入力
            _id = 0;
            _name = name;
            _subTaskDataList = new List<SubTaskData>();
        }

        public TaskData(
            TaskStatus taskStatus,
            Priority priority,
            int id,
            string name,
            IEnumerable<SubTaskData> subTaskDataList)
        {
            _taskStatus = taskStatus;
            _priority = priority;
            _id = id;
            _name = name;
            _subTaskDataList = subTaskDataList.ToList();
        }

        public ISerializable CreateData()
        {
            return new TaskDataProperty(
                _id,
                _name,
                _priority,
                _taskStatus,
                _subTaskDataList.Select(subTask => subTask.CreateData()));
        }

        public void Add(SubTaskData subTaskData)
        {
            _subTaskDataList.Add(subTaskData);
        }

        public void Add(string taskSubstance)
        {
            Add(new SubTaskData(taskSubstance));
        }

        public void Swap(SubTaskData subTask1, SubTaskData subTask2)
        {
            var index1 = GetIndexById(subTask1.Id);
            var index2 = GetIndexById(subTask2.Id);

            if (index1 < 0 || index2 < 0) return;

            var refuge = _subTaskDataList[index1];
            _subTaskDataList[index1] = _subTaskDataList[index2];
            _subTaskDataList[index2] = refuge.Clone();
        }

        public void DeleteSubTask(int id)
        {
            var subTaskIndex = GetIndexById(id);
            if (subTaskIndex >= 0)
            {
                _subTaskDataList.RemoveAt(subTaskIndex);
            }
        }

        private int GetIndexById(int id)
        {
            for (var i = 0; i < _subTaskDataList.Count; i++)
            {
                if (_subTaskDataList[i].Id == id) return i;
            }

            return -1;
        }

        private bool IsCompleted()
        {
            return _subTaskDataList.All(subTask => subTask.IsCompleted);
        }

        public bool Equals(TaskData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _id == other._id && _name == other._name && Equals(_subTaskDataList, other._subTaskDataList);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((TaskData) obj);
        }

        public override int GetHashCode()
        {
            return _id;
        }
    }
}