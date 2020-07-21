using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TimeTrackerV1
{
    public partial class TaskForm : Form
    {
        public List<Task> taskLists = new List<Task>();
        DataTable table = new DataTable();

        public TaskForm()
        {
            InitializeComponent();
        }
        
        private void TaskForm_Load(object sender, EventArgs e)
        {
            txtAddTask.Text = "";
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("SomeTask", typeof(string));
            }
        }

        #region Click Methods
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtAddTask.Text.Length > 0)
            {
                table.Rows.Add(txtAddTask.Text);
                dataGridView1.DataSource = table;
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Task task = new Task();
                task.Name = table.Rows[i]["SomeTask"].ToString();
                taskLists.Add(task);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
