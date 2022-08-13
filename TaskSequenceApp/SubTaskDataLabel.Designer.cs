using System.ComponentModel;

namespace TaskSequenceApp
{
    partial class SubTaskDataLabel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._completedCheckBox = new System.Windows.Forms.CheckBox();
            this._subTaskNameLabel = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._completedCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._subTaskNameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _completedCheckBox
            // 
            this._completedCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._completedCheckBox.Location = new System.Drawing.Point(3, 3);
            this._completedCheckBox.Name = "_completedCheckBox";
            this._completedCheckBox.Size = new System.Drawing.Size(14, 24);
            this._completedCheckBox.TabIndex = 0;
            this._completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // _subTaskNameLabel
            // 
            this._subTaskNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._subTaskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._subTaskNameLabel.Location = new System.Drawing.Point(23, 3);
            this._subTaskNameLabel.Name = "_subTaskNameLabel";
            this._subTaskNameLabel.Size = new System.Drawing.Size(274, 25);
            this._subTaskNameLabel.TabIndex = 1;
            this._subTaskNameLabel.Text = "";
            // 
            // SubTaskDataLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "SubTaskDataLabel";
            this.Size = new System.Drawing.Size(300, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox _subTaskNameLabel;

        private System.Windows.Forms.CheckBox _completedCheckBox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}