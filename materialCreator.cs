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
        public materialCreator()
        {
            InitializeComponent();
        }
        private void elementsToChose_SelectedIndexChanged(object sender, EventArgs e){}

        private void materialCreator_Load(object sender, EventArgs e)
        {
            elementsToChose.Items.AddRange(ChemicalElements.chemicalElements.Select(c=>c.ToString()).ToArray());
        }

        public Material CreatingMaterial;
        private void button1_Click(object sender, EventArgs e)
        {
            if(CreatingMaterial == null)
            {
                CreatingMaterial = new Material(textBox1.Text);
            }
            if(elementsToChose.SelectedItem != null)
            {
                var elementName = elementsToChose.SelectedItem.ToString();
                var element = ChemicalElements.GetByName(elementsToChose.SelectedItem.ToString());
                if (!CreatingMaterial.AddElement(element, (int)persent.Value))
                {
                    MessageBox.Show("Суммарный процент содержания элементов больше 100!",
                        "Нельзя добавить элемент",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                UpdateTextBox();
            }
        }

        private void UpdateTextBox()
        {

            richTextBox1.Text = CreatingMaterial.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatingMaterial.Name = textBox1.Text;
            MaterialManager.Current.materials.Add(CreatingMaterial);
            MaterialManager.Save();
            ActiveForm.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CreatingMaterial == null)
            {
                CreatingMaterial = new Material(textBox1.Text);
            }
            CreatingMaterial.Name = textBox1.Text;
            UpdateTextBox();
        }
    }
}
