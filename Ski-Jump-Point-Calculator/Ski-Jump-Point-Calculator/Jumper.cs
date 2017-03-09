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
        List<Main> jumperList = new List<Main>();

        public List<Main> GiveName()
        {
            List<Main> jumpers = (from jumper in jumperList
                                  orderby jumper.Contestant
                                  select jumper).ToList();
            return jumpers;
        }

        private void AddJumperButton_Click(object sender, EventArgs e)
        {
            try
            {
                int _number = jumperList.Count+1;
                string _name = nameInput.Text;
                string _country = countryInput.Text;
                
                jumperList.Add(new Main(_number, _name, _country));
                string[] row = {_number.ToString(), _name, _country };
                JumperDataGrid.Rows.Add(row);
                nameInput.Clear();
                countryInput.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
