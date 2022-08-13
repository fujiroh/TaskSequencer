using System.Windows.Forms;

namespace TaskSequenceApp
{
    public partial class SubTaskDataLabel : UserControl
    {
        public SubTaskDataLabel(SubTaskData subTask)
        {
            InitializeComponent();
            Set(subTask);
        }

        private void Set(SubTaskData subTask)
        {
            _subTaskNameLabel.Text = subTask.Name;
            _completedCheckBox.Checked = subTask.IsCompleted;
        }
    }
}