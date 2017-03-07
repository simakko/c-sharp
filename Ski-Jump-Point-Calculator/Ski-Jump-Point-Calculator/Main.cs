using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Jump_Point_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Jumper.Instance.BringToFront();
        }

        private void btnJumpers_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Jumper.Instance))
            {
                mainPanel.Controls.Add(Jumper.Instance);
                Jumper.Instance.Dock = DockStyle.Fill;
                Jumper.Instance.BringToFront();
            }
            else
            {
                Jumper.Instance.BringToFront();
            }
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Points.Instance))
            {
                mainPanel.Controls.Add(Points.Instance);
                Points.Instance.Dock = DockStyle.Fill;
                Points.Instance.BringToFront();
            }
            else
            {
                Points.Instance.BringToFront();
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Result.Instance))
            {
                mainPanel.Controls.Add(Result.Instance);
                Result.Instance.Dock = DockStyle.Fill;
                Result.Instance.BringToFront();
            }
            else
            {
                Result.Instance.BringToFront();
            }
        }

        private string _name;
        private int _age;
        private string _country;
        private int _points;
        private int _jumpLength;

        public Main(string name, int age, string country)
        {
            _name = name;
            _age = age;
            _country = country;
        }

        public string Name1
        {
            get { return _name; }
        }

        public int Age
        {
            get { return _age; }
        }

        public string Country
        {
            get { return _country; }
        }
    }
}
