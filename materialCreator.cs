using CalculationChargeSmelting.Scripts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculationChargeSmelting
{
    public partial class materialCreator : Form
    {
        public List<UIChemicalElement> uIChemicalElements = new List<UIChemicalElement>();
        public materialCreator(string name)
        {
            InitializeComponent();
            materialName.Text = name;
        }

        private void addElement_Click(object sender, EventArgs e)
        {
            uIChemicalElements.Add(new UIChemicalElement(flowLayoutPanel1));
        }

        private void materialCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
