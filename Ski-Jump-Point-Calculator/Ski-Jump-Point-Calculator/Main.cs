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
            try
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
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
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
        private int _number;
        private string _name;
        private string _country;


        public Main(int number, string name, string country)
        {
            _name = name;
            _number = number;
            _country = country;
        }

        public string Contestant
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

    }
}
