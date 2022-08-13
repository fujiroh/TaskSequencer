using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TaskSequenceApp
{
    public class ApplicationController
    {
        private const string FilePath = "taskData.json";

        private IEnumerable<TaskData> _masterTaskList;
        public IEnumerable<TaskData> MasterDataList => _masterTaskList;

        public ApplicationController()
        {
            _masterTaskList = new List<TaskData>();
            // Load();
        }

        public void Load()
        {
            try
            {
                var json = JsonSerializer.Read(FilePath);
                var dataPropertyList = JsonConverter<TaskDataProperty>.ConvertToInnerValue(json);
                SetList(dataPropertyList);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("ファイルが見つかりません。");
            }
        }

        private void SetList(IEnumerable<TaskDataProperty> dataPropertyList)
        {
            _masterTaskList = ConvertToInnerValue(dataPropertyList);
        }

        private static IEnumerable<TaskData> ConvertToInnerValue(IEnumerable<TaskDataProperty> dataPropertyList)
        {
            return dataPropertyList.Select(dataProperty =>
                new TaskData(
                    dataProperty.Status,
                    dataProperty.Priority,
                    dataProperty.Id,
                    dataProperty.Name,
                    JsonConverter<SubTaskDataProperty>.ConvertToInnerValue(dataProperty.SubTaskDataJson)
                        .Select(subTaskDataProperty =>
                            new SubTaskData(subTaskDataProperty.Id,
                                subTaskDataProperty.Name,
                                subTaskDataProperty.IsCompleted)))).ToList();
        }

        public void Save()
        {
            try
            {
                var dataPropertyList = _masterTaskList.Select(data => (TaskDataProperty) data.CreateData());
                JsonSerializer.Write(dataPropertyList, FilePath);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("ファイルが見つかりません");
            }
        }
    }
}