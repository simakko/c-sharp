using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ski_Jump_Point_Calculator
{
    public partial class JumperController : UserControl
    {
        public static List<Jumper> JumperList { get; set; }
        private static JumperController _instance;
        public static JumperController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JumperController();
                }
                return _instance;
            }
        }
        public JumperController()
        {
            InitializeComponent();
        }

        private void AddJumperButton_Click(object sender, EventArgs e)
        {
            try
            {
                int jumperNumber = 0;
                if (JumperList.Count > 0)
                {
                    jumperNumber = JumperList[JumperList.Count - 1].Number;
                }
                int _number = jumperNumber + 1;
                string _name = nameInput.Text.ToString();
                string _country = countryInput.Text.ToString();

                JumperList.Add(new Jumper(_number, _name, _country));
                object[] row = { _number.ToString(), _name, _country };
                JumperDataGrid.Rows.Add(row);
                nameInput.Clear();
                countryInput.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(JumperDataGrid.SelectedRows[0].Cells[0].Value);
            var thisJumper = JumperList.First(x => x.Number == index);
            JumperList.Remove(thisJumper);
            
            JumperDataGrid.Rows.RemoveAt(JumperDataGrid.SelectedRows[0].Index);
        }
    }
}
