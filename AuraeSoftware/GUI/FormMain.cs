using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuraeSoftware.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripMain.Show(Cursor.Position);
            }
        }




        private void tinhNang1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        List<Thread> threads = new List<Thread>();
        private void tinhNang2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

      
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread childThread = new Thread(() =>
                    {
                       
                        // do something
                    });
                    threads.Add(childThread);
                    childThread.IsBackground = true;
                    childThread.Start();
                }
               
            });
            thread.IsBackground = true;
            threads.Add(thread);
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var thread in threads)
                {
                    try
                    {
                        thread.Abort();
                    }
                    catch
                    {

                    }
                }
                threads.Clear();
            }
            catch
            {

            }
        }
    }
}
