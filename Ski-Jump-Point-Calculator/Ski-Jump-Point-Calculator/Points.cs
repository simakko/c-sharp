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

        
        private double _score;
        private int _number;
        private double _jumpLength;
        private double _criticalPoint;
        private double _levelCompensation;
        private double _platformChange;
        private double _platformCompensation;
        private double _windCompensation;
        private double _windChance1;
        private double _windChance2;
        private double _windChance3;
        private double _windChance4;
        private double _windChance5;
        private double _stylePoints;
        private double _stylePoints1;
        private double _stylePoints2;
        private double _stylePoints3;
        private double _stylePoints4;
        private double _stylePoints5;

        public List<Main> GetNames()
        {
            Jumper points = new Jumper();
            List<Main> names = points.GiveName();
            return names;
        }

        private void nameComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = GetNames();
            nameComboBox.DataSource = bindingSource1.DataSource;
            nameComboBox.DisplayMember = Name;
            MessageBox.Show(Name);
        }

        private void AddPointsButton_Click(object sender, EventArgs e)
        {
            _number = int.Parse(nameComboBox.SelectedText);
            _jumpLength = double.Parse(jumpLength.Text);
            _criticalPoint = double.Parse(criticalPoint.Text);
            _levelCompensation = double.Parse(levelCompensation.Text);
            _platformChange = double.Parse(levelChange.Text);
            _windChance1 = double.Parse(windCheck1.Text);
            _windChance2 = double.Parse(windCheck2.Text);
            _windChance3 = double.Parse(windCheck3.Text);
            _windChance4 = double.Parse(windCheck4.Text);
            _windChance5 = double.Parse(windCheck5.Text);
            _stylePoints1 = double.Parse(stylePoints1.Text);
            _stylePoints2 = double.Parse(stylePoints2.Text);
            _stylePoints3 = double.Parse(stylePoints3.Text);
            _stylePoints4 = double.Parse(stylePoints4.Text);
            _stylePoints5 = double.Parse(stylePoints5.Text);

            _windCompensation = countWindEffect(_criticalPoint, _windChance1, _windChance2, _windChance3, _windChance4, _windChance5);
            _score = countLengthScore(_jumpLength, _criticalPoint, _windCompensation);
            _stylePoints = countStylePoints(_stylePoints1, _stylePoints2, _stylePoints3, _stylePoints4, _stylePoints5);
            _platformCompensation = countPlatformCompensation(_criticalPoint, _platformChange, _levelCompensation);

        }

        public double countWindEffect(double _criticalPoint, double _windChance1, double _windChance2, double _windChance3, double _windChance4, double _windChance5)
        {
            List<double> windEffect = new List<double> { _windChance1, _windChance2, _windChance3, _windChance4, _windChance5 };
            double average = windEffect.Average();
            double wind = average * (_criticalPoint - 36) / 20;
            wind = Math.Round(wind * 2, MidpointRounding.AwayFromZero) / 2;
            double compensationMultiplier;

            if (_criticalPoint < 99 || _criticalPoint == 99)
            {
                compensationMultiplier = 2;
            }
            else
            {
                compensationMultiplier = 1.8;
            }
            wind = wind * compensationMultiplier;

            return wind;
        }

        public double countLengthScore(double _jumpLength, double _criticalPoint, double _windCompensation)
        {
            double lengthScore;
            double compensationMultiplier;

            if (_criticalPoint < 99 || _criticalPoint == 99)
            {
                compensationMultiplier = 2;
            }
            else
            {
                compensationMultiplier = 1.8;
            }

            if (_jumpLength > _criticalPoint || _jumpLength == _criticalPoint)
            {
                lengthScore = (_jumpLength - _criticalPoint) * compensationMultiplier + 60;
            }
            else
            {
                lengthScore = 60 - ((_criticalPoint - _jumpLength) * compensationMultiplier);
            }

            return lengthScore;
        }

        public double countStylePoints(double _stylePoints1, double _stylePoints2, double _stylePoints3, double _stylePoints4, double _stylePoints5)
        {
            List<double> stylePoints = new List<double> { _stylePoints1, _stylePoints2, _stylePoints3, _stylePoints4, _stylePoints5 };
            stylePoints.Remove(stylePoints.Max());
            stylePoints.Remove(stylePoints.Min());
            
            return stylePoints.Sum();
        }

        public double countPlatformCompensation(double _criticalPoint, double _platformChange, double _levelCompensation)
        {
            double compensation;
            double compensationMultiplier;
            if (_criticalPoint < 99 || _criticalPoint == 99)
            {
                compensationMultiplier = 2;
            }
            else
            {
                compensationMultiplier = 1.8;
            }

            compensation = (_platformChange * _levelCompensation) * compensationMultiplier;

            return compensation;
        }
    }
}
