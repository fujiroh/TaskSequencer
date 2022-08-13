using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TaskSequenceApp;

namespace ApplicationTest
{
    [TestFixture]
    public class JsonSerializerTest
    {
        [Test]
        public void SerializeTest()
        {
            var taskDataList = new List<TaskData>()
            {
                new TaskData("A"),
                new TaskData("BB"),
                new TaskData("CCC"),
                new TaskData("DDDD"),
                new TaskData("EEEEE"),
                new TaskData("FFFFFF")
            };
            var subtaskDataList = new List<SubTaskData>()
            {
                new SubTaskData("1"),
                new SubTaskData("2"),
                new SubTaskData("3"),
                new SubTaskData("4"),
            };
            
            foreach (var task in taskDataList)
            {
                subtaskDataList.ForEach(sub => task.Add(sub));
            }

            var data = taskDataList.Select(task => (TaskDataProperty)task.CreateData());
            var json = JsonConverter<TaskDataProperty>.ConvertToJson(data);

            var inner = JsonConverter<TaskDataProperty>.ConvertToInnerValue(json);
        }
    }
}