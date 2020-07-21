using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace TimeTrackerV1
{
    public partial class MainForm : Form
    {
        private long ticks;
        private DateTime startTime;
        private DateTime endTime;
        private double amountOfTime;
        TaskForm tasksForm = new TaskForm();
        List<Task> myList = new List<Task>();
        List<double> countTime = new List<double>();

        public MainForm()
        {
            InitializeComponent();
            btnStartTask.Enabled = false;
            btnEndTask.Enabled = false;
            btnCalculateTime.Enabled = false;
            btnGenerateXML.Enabled = false;
        }

        #region Main Methods

        private void EditTaskList()
        {
            cmbChooseTask.Text = "";
            myList.Clear();
            if (myList.Any())
            {
                tasksForm.dataGridView1.DataSource = myList;
            }
            if (DialogResult.OK == tasksForm.ShowDialog())
            {
                myList = tasksForm.taskLists;
                addListToComboBox();
            }
        }

        private void addListToComboBox()
        {
            cmbChooseTask.Items.Clear();
            cmbChooseTask.BeginUpdate();
            for (int i = 0; i < myList.Count; i++)
            {
                cmbChooseTask.Items.Add(myList[i].Name);
            }
            txtTask.Text = "";
            cmbChooseTask.SelectedText = "-->Select Task<--";
            cmbChooseTask.EndUpdate();
        }

        private double TimeCalculate()
        {
            endTime = DateTime.Now;
            TimeSpan tSpan = endTime - startTime;
            double seconds = tSpan.TotalSeconds;
            return seconds;
        }

        private void cmbChooseTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTask.Text = cmbChooseTask.SelectedItem.ToString();
            btnStartTask.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks >= 1)
            {
                txtCurrentTime.Text = ticks.ToString() + " min";
            }
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            EditTaskList();
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            ticks = 0;
            startTime = DateTime.Now;
            timer1.Start();
            btnCalculateTime.Enabled = false;
            btnStartTask.Enabled = false;
            btnEndTask.Enabled = true;
            txtTotalTime.Text = string.Empty;
            txtCurrentTime.Text = "time started";
        }
        #endregion

        #region Click Methods
        private void btnEndTask_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            var seconds = TimeCalculate();

            countTime.Add(seconds);

            ticks = 0;
            txtCurrentTime.Text = "choose another task";
            btnEndTask.Enabled = false;

            if (seconds >= 60)
            {
                txtTotalTime.Text = (seconds / 60).ToString("0") + " min";
            }
            else if (seconds >= 3600)
            {
                txtTotalTime.Text = (seconds / 3600).ToString("0") + " hours";
            }
            else
            {
                txtTotalTime.Text = seconds.ToString("0") + " sec";
            }

            btnStartTask.Enabled = true;
            btnCalculateTime.Enabled = true;

            var row = new string[] { txtTask.Text, (seconds / 60 < 1 ? seconds
                                                                      : seconds / 60).ToString("F2") };
            var lvi = new ListViewItem(row);

            listViewTasks.Items.Add(lvi);
        }

        private void btnCalculateTime_Click(object sender, EventArgs e)
        {
            amountOfTime = 0;
            for (int i = 0; i < countTime.Count; i++)
            {
                amountOfTime += countTime[i];
            }
            txtCalculateInput.Text = (amountOfTime / 3600 < 1 ? (amountOfTime / 60).ToString("F2") + " minutes"
                                                     : (amountOfTime / 3600).ToString("F2") + " hours");
            btnGenerateXML.Enabled = true;
        }

        private void btnGenerateXML_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create("task.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Tasks");
                const int SUBITEM1_POS = 0;
                const int SUBITEM2_POS = 1;

                for (int i = 0; i < listViewTasks.Items.Count; i++)
                {
                    String currentSubItem1 = listViewTasks.Items[i].SubItems[SUBITEM1_POS].Text;
                    String currentSubItem2 = listViewTasks.Items[i].SubItems[SUBITEM2_POS].Text;
                    writer.WriteStartElement("Task");
                    writer.WriteElementString("TaskName", currentSubItem1);
                    writer.WriteElementString("TaskTime", currentSubItem2);
                    writer.WriteEndElement();
                }

                writer.WriteStartElement("CalculateTimes");
                writer.WriteValue(amountOfTime);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            MessageBox.Show("The XML file was generated");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
