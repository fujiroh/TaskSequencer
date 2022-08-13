using System;
using System.Runtime.Serialization;

namespace TaskSequenceApp
{
    [DataContract]
    public class SubTaskData : IEquatable<SubTaskData>, ICreatableJsonData
    {
        private readonly int _id;
        private readonly string _name;

        public int Id => _id;
        public string Name => _name;
        public bool IsCompleted { get; set; }

        public SubTaskData(string name)
        {
            // TODO:IDの入力 
            _id = 0;
            _name = name;
        }

        public SubTaskData(int id, string name, bool isCompleted)
        {
            _id = id;
            _name = name;
            IsCompleted = isCompleted;
        }

        private SubTaskData(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public ISerializable CreateData()
        {
            return new SubTaskDataProperty(_id, _name, IsCompleted);
        }

        public SubTaskData Clone()
        {
            return new SubTaskData(_id, _name);
        }

        public bool Equals(SubTaskData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _id == other._id && _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SubTaskData) obj);
        }

        public override int GetHashCode()
        {
            return _id;
        }
    }
}