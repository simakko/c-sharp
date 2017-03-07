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
    public partial class Points : UserControl
    {
        private static Points _instance;

        public static Points Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Points();
                }
                return _instance;
            }
        }

        public Points()
        {
            InitializeComponent();
        }
    }
}
