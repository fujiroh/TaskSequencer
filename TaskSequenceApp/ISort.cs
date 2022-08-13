using System.Collections.Generic;

namespace TaskSequenceApp
{
    public interface ISort
    {
        void Sort(IEnumerable<TaskData> taskList, bool isAscendingOrder);
    }
}