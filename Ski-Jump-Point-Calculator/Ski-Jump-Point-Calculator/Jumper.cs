using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Jump_Point_Calculator
{
    public partial class Jumper : UserControl
    {
        private static Jumper _instance;

        public static Jumper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Jumper();
                }
                return _instance;
            }
        }
        public Jumper()
        {
            InitializeComponent();

        }
        List<Main> jumpers = new List<Main>();
        private void AddJumperButton_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = nameInput.Text;
                int _age = int.Parse(ageInput.Text);
                string _country = countryInput.Text;
                jumpers.Add(new Main(_name, _age, _country));

                var source = new BindingSource();
                source.DataSource = jumpers;
                JumperDataGrid.DataSource = source;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
