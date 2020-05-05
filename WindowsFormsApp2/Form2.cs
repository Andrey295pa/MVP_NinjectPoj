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
    public partial class Form2 : Form,IChangeView
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public string AnotherText {
            get => textBox1.Text;
            set => textBox1.Text=value;
        }

        public new void Show()
        {
            this.ShowDialog();
        }
    }
}
