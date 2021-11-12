using _8.hét.Abstractions;
using _8.hét.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.hét
{

    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();
        Toy _nextToy;
        private IToyFactory _toyfactory;
        public IToyFactory ToyFactory
        {
            get { return _toyfactory; }
            set { _toyfactory = value;
                DisplayNext();

            }
        }

        public Form1()
        {
            InitializeComponent();
            ToyFactory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = ToyFactory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainpanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var item in _toys)
            {
                item.MoveToy();
                if (item.Left > maxPosition)
                    maxPosition = item.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainpanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            ToyFactory = new CarFactory();
        }

        private void btnball_Click(object sender, EventArgs e)
        {
            ToyFactory = new BallFactory
            {
                BallColor = button1.BackColor
            };
        }
        private void btnpresent_Click(object sender, EventArgs e)
        {
            ToyFactory = new PresentFactory
            {
            BoxColor = btncolorbox.BackColor,
            RibbenColor = btncolorribben.BackColor
            };
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = ToyFactory.CreateNew();
            _nextToy.Top = lblnext.Top + lblnext.Height + 20;
            _nextToy.Left = lblnext.Left;
            Controls.Add(_nextToy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }

       
    }
}
