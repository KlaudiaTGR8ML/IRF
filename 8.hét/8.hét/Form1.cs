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
        private IToyFactory _toyfactory;
        public IToyFactory ToyFactory
        {
            get { return _toyfactory; }
            set { _toyfactory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            ToyFactory = new BallFactory();
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
    }
}
