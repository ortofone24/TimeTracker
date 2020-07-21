namespace TimeTrackerV1
{
    partial class TaskForm
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
            this.pnlTopBannerTF = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBoxTask = new System.Windows.Forms.GroupBox();
            this.txtAddTask = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlTopBannerTF.SuspendLayout();
            this.grpBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBannerTF
            // 
            this.pnlTopBannerTF.BackColor = System.Drawing.Color.Silver;
            this.pnlTopBannerTF.Controls.Add(this.lblTitle);
            this.pnlTopBannerTF.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBannerTF.Name = "pnlTopBannerTF";
            this.pnlTopBannerTF.Size = new System.Drawing.Size(330, 76);
            this.pnlTopBannerTF.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(12, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ENTER A NEW TASK";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxTask
            // 
            this.grpBoxTask.Controls.Add(this.txtAddTask);
            this.grpBoxTask.Controls.Add(this.btnOk);
            this.grpBoxTask.Controls.Add(this.btnRemoveTask);
            this.grpBoxTask.Controls.Add(this.btnAddTask);
            this.grpBoxTask.Location = new System.Drawing.Point(0, 380);
            this.grpBoxTask.Name = "grpBoxTask";
            this.grpBoxTask.Size = new System.Drawing.Size(330, 165);
            this.grpBoxTask.TabIndex = 2;
            this.grpBoxTask.TabStop = false;
            // 
            // txtAddTask
            // 
            this.txtAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddTask.Location = new System.Drawing.Point(102, 22);
            this.txtAddTask.Name = "txtAddTask";
            this.txtAddTask.Size = new System.Drawing.Size(218, 27);
            this.txtAddTask.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(10, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(310, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(12, 70);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(312, 32);
            this.btnRemoveTask.TabIndex = 1;
            this.btnRemoveTask.Text = "Remove Selected Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(12, 21);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(84, 30);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(308, 266);
            this.dataGridView1.TabIndex = 5;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBoxTask);
            this.Controls.Add(this.pnlTopBannerTF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Form";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.pnlTopBannerTF.ResumeLayout(false);
            this.pnlTopBannerTF.PerformLayout();
            this.grpBoxTask.ResumeLayout(false);
            this.grpBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBannerTF;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBoxTask;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtAddTask;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}