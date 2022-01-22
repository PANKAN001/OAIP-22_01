using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAIP_22_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button helloButton = new Button();
            helloButton.BackColor = Color.Yellow;
            helloButton.ForeColor = Color.Blue;
            helloButton.Location = new Point(30, 30);
            helloButton.Text = "Привет";
            groupBox1.Controls.Add(helloButton);

            tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.RowStyles[0].Height = 40;

            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[0].Width = 50;

            Button saveButton = new Button();
            tableLayoutPanel1.Controls.Add(saveButton);
            tableLayoutPanel1.Controls.Add(saveButton, 2, 2);

            button1.Location = new Point(200, 300);

            button1.Size = new Size { Width = 50, Height = 25 };
            button1.Width = 100;
            button1.Height = 35;

            //button1.Anchor = AnchorStyles.Left;
            //button1.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            TabPage newTabPage = new TabPage();
            newTabPage.Text = "Континенты";
            tabControl1.TabPages.Add(newTabPage);

            //tabControl1.TabPages.RemoveAt(0);
            //tabControl1.TabPages.Remove(newTabPage);

            tabControl1.TabPages[0].Text = "Первая вкладка";
        }
    }
}
