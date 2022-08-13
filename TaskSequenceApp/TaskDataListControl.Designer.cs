using System.ComponentModel;





namespace TaskSequenceApp
{
    partial class TaskDataListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._taskNameLabel = new System.Windows.Forms.RichTextBox();
            this._statusLabel = new System.Windows.Forms.Label();
            this._priorityLabel = new System.Windows.Forms.Label();
            this._expandCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._addBtn = new System.Windows.Forms.Button();
            this._subTaskLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _taskNameLabel
            // 
            this._taskNameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._taskNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._taskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._taskNameLabel.Location = new System.Drawing.Point(4, 4);
            this._taskNameLabel.Name = "_taskNameLabel";
            this._taskNameLabel.Size = new System.Drawing.Size(186, 22);
            this._taskNameLabel.TabIndex = 0;
            this._taskNameLabel.Text = "";
            // 
            // _statusLabel
            // 
            this._statusLabel.BackColor = System.Drawing.Color.Transparent;
            this._statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statusLabel.Location = new System.Drawing.Point(197, 1);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(34, 28);
            this._statusLabel.TabIndex = 0;
            this._statusLabel.Text = "Doing";
            this._statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _priorityLabel
            // 
            this._priorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._priorityLabel.Location = new System.Drawing.Point(238, 1);
            this._priorityLabel.Name = "_priorityLabel";
            this._priorityLabel.Size = new System.Drawing.Size(56, 28);
            this._priorityLabel.TabIndex = 0;
            this._priorityLabel.Text = "↑Medium";
            this._priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _expandCheckBox
            // 
            this._expandCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this._expandCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._expandCheckBox.Location = new System.Drawing.Point(329, 4);
            this._expandCheckBox.Name = "_expandCheckBox";
            this._expandCheckBox.Size = new System.Drawing.Size(20, 20);
            this._expandCheckBox.TabIndex = 0;
            this._expandCheckBox.UseVisualStyleBackColor = true;
            this._expandCheckBox.CheckedChanged += new System.EventHandler(this._expandCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.82442F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this._addBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._taskNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._statusLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._priorityLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._expandCheckBox, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _addBtn
            // 
            this._addBtn.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._addBtn.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this._addBtn.Location = new System.Drawing.Point(301, 4);
            this._addBtn.Name = "_addBtn";
            this._addBtn.Size = new System.Drawing.Size(21, 22);
            this._addBtn.TabIndex = 0;
            this._addBtn.Text = "+";
            this._addBtn.UseVisualStyleBackColor = true;
            this._addBtn.Click += new System.EventHandler(this._addBtn_Click);
            // 
            // _subTaskLayoutPanel
            // 
            this._subTaskLayoutPanel.AutoSize = true;
            this._subTaskLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._subTaskLayoutPanel.BackColor = System.Drawing.Color.White;
            this._subTaskLayoutPanel.ColumnCount = 1;
            this._subTaskLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._subTaskLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._subTaskLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._subTaskLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this._subTaskLayoutPanel.Name = "_subTaskLayoutPanel";
            this._subTaskLayoutPanel.RowCount = 1;
            this._subTaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._subTaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._subTaskLayoutPanel.Size = new System.Drawing.Size(373, 182);
            this._subTaskLayoutPanel.TabIndex = 2;
            // 
            // TaskDataListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._subTaskLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaskDataListControl";
            this.Size = new System.Drawing.Size(373, 212);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button _addBtn;

        private System.Windows.Forms.TableLayoutPanel _subTaskLayoutPanel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.CheckBox _expandCheckBox;

        private System.Windows.Forms.RichTextBox _taskNameLabel;

        private System.Windows.Forms.Label _statusLabel;
        private System.Windows.Forms.Label _priorityLabel;

        #endregion
    }
}