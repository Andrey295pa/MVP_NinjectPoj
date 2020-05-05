using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.view;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form, IViewMessage
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string sms {
            get => this.textBox1.Text; 
            set => this.textBox1.Text=value;
        }

        public event Action Save;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Save!=null)
            {
                Save.Invoke();
            }
          
        }

        public new  void Show() {
            Application.Run(this);

        }
    }
}
