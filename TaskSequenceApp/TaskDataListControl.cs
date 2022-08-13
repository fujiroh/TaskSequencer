using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskSequenceApp
{
    public partial class TaskDataListControl : UserControl
    {
        private TaskData _taskData;

        public TaskDataListControl()
        {
            InitializeComponent();
            Expand();
        }

        public TaskDataListControl(TaskData taskData)
        {
            InitializeComponent();
            _taskData = taskData;
            Set(_taskData);
        }

        private void Set(TaskData taskData)
        {
            _priorityLabel.Text = GetPriorityText(taskData.Priority);
            _priorityLabel.ForeColor = GetPriorityColor(taskData.Priority);
            _statusLabel.Text = GetStatusText(taskData.Status);
            _taskNameLabel.Text = taskData.Name;
            Expand();
        }

        private static string GetStatusText(TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.Do: return "Do";
                case TaskStatus.Doing: return "Doing";
                case TaskStatus.Done: return "Done";
                default: return "";
            }
        }

        private static string GetPriorityText(Priority priority)
        {
            switch (priority)
            {
                case Priority.Low: return "Low";
                case Priority.Medium: return "Medium";
                case Priority.High: return "High";
                default: return "";
            }
        }

        private static Color GetPriorityColor(Priority priority)
        {
            switch (priority)
            {
                case Priority.Low: return Color.Green;
                case Priority.Medium: return Color.Orange;
                case Priority.High: return Color.Red;
                default: return Color.Transparent;
            }
        }

        private void _addBtn_Click(object sender, EventArgs e)
        {
            var subTaskLabel = new SubTaskDataLabel(new SubTaskData("テスト用"));
            subTaskLabel.Width = _subTaskLayoutPanel.Width;
            _subTaskLayoutPanel.Controls.Add(subTaskLabel);
            Invalidate();
        }

        private void _expandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _subTaskLayoutPanel.Visible = _expandCheckBox.Checked;
            Expand();
        }

        private void Expand()
        {
            this.Height = _expandCheckBox.Checked
                ? tableLayoutPanel1.Height + _subTaskLayoutPanel.Height
                : tableLayoutPanel1.Height;
        }
    }
}