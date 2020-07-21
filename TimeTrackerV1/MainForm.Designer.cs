namespace TimeTrackerV1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTopBannerMF = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimeTracker = new System.Windows.Forms.Label();
            this.grpBoxTimeTracker = new System.Windows.Forms.GroupBox();
            this.btnGenerateXML = new System.Windows.Forms.Button();
            this.txtCalculateInput = new System.Windows.Forms.TextBox();
            this.btnCalculateTime = new System.Windows.Forms.Button();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.chTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.cmbChooseTask = new System.Windows.Forms.ComboBox();
            this.lblChooseTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnEndTask = new System.Windows.Forms.Button();
            this.grpBox2TimeTracker = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBannerMF.SuspendLayout();
            this.grpBoxTimeTracker.SuspendLayout();
            this.grpBox2TimeTracker.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBannerMF
            // 
            this.pnlTopBannerMF.BackColor = System.Drawing.Color.Silver;
            this.pnlTopBannerMF.Controls.Add(this.button1);
            this.pnlTopBannerMF.Controls.Add(this.lblTimeTracker);
            this.pnlTopBannerMF.Location = new System.Drawing.Point(-3, -3);
            this.pnlTopBannerMF.Name = "pnlTopBannerMF";
            this.pnlTopBannerMF.Size = new System.Drawing.Size(563, 83);
            this.pnlTopBannerMF.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(505, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimeTracker
            // 
            this.lblTimeTracker.AutoSize = true;
            this.lblTimeTracker.BackColor = System.Drawing.Color.Silver;
            this.lblTimeTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeTracker.Location = new System.Drawing.Point(34, 12);
            this.lblTimeTracker.Name = "lblTimeTracker";
            this.lblTimeTracker.Size = new System.Drawing.Size(430, 61);
            this.lblTimeTracker.TabIndex = 1;
            this.lblTimeTracker.Text = "TIME TRACKER";
            this.lblTimeTracker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxTimeTracker
            // 
            this.grpBoxTimeTracker.Controls.Add(this.btnGenerateXML);
            this.grpBoxTimeTracker.Controls.Add(this.txtCalculateInput);
            this.grpBoxTimeTracker.Controls.Add(this.btnCalculateTime);
            this.grpBoxTimeTracker.Controls.Add(this.txtTotalTime);
            this.grpBoxTimeTracker.Controls.Add(this.listViewTasks);
            this.grpBoxTimeTracker.Controls.Add(this.txtCurrentTime);
            this.grpBoxTimeTracker.Controls.Add(this.lblTotalTime);
            this.grpBoxTimeTracker.Controls.Add(this.lblCurrentTime);
            this.grpBoxTimeTracker.Location = new System.Drawing.Point(12, 86);
            this.grpBoxTimeTracker.Name = "grpBoxTimeTracker";
            this.grpBoxTimeTracker.Size = new System.Drawing.Size(528, 386);
            this.grpBoxTimeTracker.TabIndex = 2;
            this.grpBoxTimeTracker.TabStop = false;
            // 
            // btnGenerateXML
            // 
            this.btnGenerateXML.Location = new System.Drawing.Point(6, 344);
            this.btnGenerateXML.Name = "btnGenerateXML";
            this.btnGenerateXML.Size = new System.Drawing.Size(516, 36);
            this.btnGenerateXML.TabIndex = 7;
            this.btnGenerateXML.TabStop = false;
            this.btnGenerateXML.Text = "Generate Daily XML Raport";
            this.btnGenerateXML.UseVisualStyleBackColor = true;
            this.btnGenerateXML.Click += new System.EventHandler(this.btnGenerateXML_Click);
            // 
            // txtCalculateInput
            // 
            this.txtCalculateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCalculateInput.Location = new System.Drawing.Point(270, 302);
            this.txtCalculateInput.Name = "txtCalculateInput";
            this.txtCalculateInput.Size = new System.Drawing.Size(248, 30);
            this.txtCalculateInput.TabIndex = 7;
            this.txtCalculateInput.TabStop = false;
            // 
            // btnCalculateTime
            // 
            this.btnCalculateTime.Location = new System.Drawing.Point(6, 296);
            this.btnCalculateTime.Name = "btnCalculateTime";
            this.btnCalculateTime.Size = new System.Drawing.Size(244, 36);
            this.btnCalculateTime.TabIndex = 7;
            this.btnCalculateTime.TabStop = false;
            this.btnCalculateTime.Text = "Calculate All Time";
            this.btnCalculateTime.UseVisualStyleBackColor = true;
            this.btnCalculateTime.Click += new System.EventHandler(this.btnCalculateTime_Click);
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTotalTime.Location = new System.Drawing.Point(274, 37);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(248, 27);
            this.txtTotalTime.TabIndex = 9;
            this.txtTotalTime.TabStop = false;
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTask,
            this.chTime});
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(6, 70);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(516, 207);
            this.listViewTasks.TabIndex = 10;
            this.listViewTasks.TabStop = false;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // chTask
            // 
            this.chTask.Text = "Task Name";
            this.chTask.Width = 270;
            // 
            // chTime
            // 
            this.chTime.Text = "Task Time";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 150;
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCurrentTime.Location = new System.Drawing.Point(6, 37);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.Size = new System.Drawing.Size(236, 27);
            this.txtCurrentTime.TabIndex = 7;
            this.txtCurrentTime.TabStop = false;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalTime.Location = new System.Drawing.Point(270, 14);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(88, 20);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "Total Time";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrentTime.Location = new System.Drawing.Point(6, 14);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(107, 20);
            this.lblCurrentTime.TabIndex = 7;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // btnAddTasks
            // 
            this.btnAddTasks.BackColor = System.Drawing.Color.Silver;
            this.btnAddTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddTasks.Location = new System.Drawing.Point(6, 138);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(512, 54);
            this.btnAddTasks.TabIndex = 0;
            this.btnAddTasks.Text = "ADD TASKS";
            this.btnAddTasks.UseVisualStyleBackColor = false;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
            // 
            // cmbChooseTask
            // 
            this.cmbChooseTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbChooseTask.FormattingEnabled = true;
            this.cmbChooseTask.Location = new System.Drawing.Point(6, 41);
            this.cmbChooseTask.Name = "cmbChooseTask";
            this.cmbChooseTask.Size = new System.Drawing.Size(236, 28);
            this.cmbChooseTask.TabIndex = 1;
            this.cmbChooseTask.TabStop = false;
            this.cmbChooseTask.SelectedIndexChanged += new System.EventHandler(this.cmbChooseTask_SelectedIndexChanged);
            // 
            // lblChooseTask
            // 
            this.lblChooseTask.AutoSize = true;
            this.lblChooseTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChooseTask.Location = new System.Drawing.Point(6, 18);
            this.lblChooseTask.Name = "lblChooseTask";
            this.lblChooseTask.Size = new System.Drawing.Size(107, 20);
            this.lblChooseTask.TabIndex = 2;
            this.lblChooseTask.Text = "Choose Task";
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTask.Location = new System.Drawing.Point(274, 41);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(248, 27);
            this.txtTask.TabIndex = 3;
            this.txtTask.TabStop = false;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTask.Location = new System.Drawing.Point(270, 18);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(106, 20);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Current Task";
            // 
            // btnStartTask
            // 
            this.btnStartTask.Location = new System.Drawing.Point(6, 86);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(236, 36);
            this.btnStartTask.TabIndex = 5;
            this.btnStartTask.TabStop = false;
            this.btnStartTask.Text = "Start Task";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnEndTask
            // 
            this.btnEndTask.Location = new System.Drawing.Point(274, 86);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(248, 36);
            this.btnEndTask.TabIndex = 6;
            this.btnEndTask.TabStop = false;
            this.btnEndTask.Text = "End Task";
            this.btnEndTask.UseVisualStyleBackColor = true;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // grpBox2TimeTracker
            // 
            this.grpBox2TimeTracker.Controls.Add(this.btnEndTask);
            this.grpBox2TimeTracker.Controls.Add(this.btnAddTasks);
            this.grpBox2TimeTracker.Controls.Add(this.cmbChooseTask);
            this.grpBox2TimeTracker.Controls.Add(this.btnStartTask);
            this.grpBox2TimeTracker.Controls.Add(this.lblChooseTask);
            this.grpBox2TimeTracker.Controls.Add(this.txtTask);
            this.grpBox2TimeTracker.Controls.Add(this.lblTask);
            this.grpBox2TimeTracker.Location = new System.Drawing.Point(12, 478);
            this.grpBox2TimeTracker.Name = "grpBox2TimeTracker";
            this.grpBox2TimeTracker.Size = new System.Drawing.Size(528, 203);
            this.grpBox2TimeTracker.TabIndex = 3;
            this.grpBox2TimeTracker.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 693);
            this.Controls.Add(this.grpBox2TimeTracker);
            this.Controls.Add(this.grpBoxTimeTracker);
            this.Controls.Add(this.pnlTopBannerMF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.pnlTopBannerMF.ResumeLayout(false);
            this.pnlTopBannerMF.PerformLayout();
            this.grpBoxTimeTracker.ResumeLayout(false);
            this.grpBoxTimeTracker.PerformLayout();
            this.grpBox2TimeTracker.ResumeLayout(false);
            this.grpBox2TimeTracker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBannerMF;
        private System.Windows.Forms.Label lblTimeTracker;
        private System.Windows.Forms.GroupBox grpBoxTimeTracker;
        private System.Windows.Forms.ComboBox cmbChooseTask;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblChooseTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.GroupBox grpBox2TimeTracker;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.Button btnGenerateXML;
        private System.Windows.Forms.TextBox txtCalculateInput;
        private System.Windows.Forms.Button btnCalculateTime;
        private System.Windows.Forms.ColumnHeader chTask;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}