using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTaskSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Enabled = false;
                txtTask1.Text = "";
                txtTask2.Text = "";
                txtTask3.Text = "";
                txtMsg.Text = "";
                Refresh();

                int sumSleep1 = 0;
                int sumSleep2 = 0;
                int sumSleep3 = 0;
                List<Task> taskList = new List<Task>();
                {
                    Task task1 = Task.Run(() =>
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            System.Threading.Thread.Sleep(300);
                            sumSleep1 += 300;
                        }
                    });
                    taskList.Add(task1);

                    Task task2 = Task.Run(() =>
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            System.Threading.Thread.Sleep(400);
                            sumSleep2 += 400;
                        }
                    });
                    taskList.Add(task2);

                    Task task3 = Task.Run(() =>
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            System.Threading.Thread.Sleep(200);
                            sumSleep3 += 200;
                        }
                    });
                    taskList.Add(task3);
                }

                // タスク終了待ち
                Task.WaitAll(taskList.ToArray());
                // タスク削除
                foreach (Task task in taskList)
                {
                    task.Dispose();
                }
                txtTask1.Text = sumSleep1.ToString();
                txtTask2.Text = sumSleep2.ToString();
                txtTask3.Text = sumSleep3.ToString();
                txtMsg.Text = "End";
                btnStart.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
