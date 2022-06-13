using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculationChargeSmelting
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        private void shichtType_SelectedIndexChanged(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}

        public Materials ShichtMaterials = new Materials();

        public List<UIMaterial> UIMaterials = new List<UIMaterial>();

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialManager.Load();
        }

        private void LoadMaterials_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            MaterialManager.Load();
            foreach (var mat in MaterialManager.Current.materials)
            {
                comboBox2.Items.Add(mat.ToString());
            }
        }
        private void UpdateShichtMaterials()
        {
            var s = "";
            foreach(var mat in ShichtMaterials.materials)
            {
                s += mat.ToString() + "\n\n";
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var s = "";
            //var result = new Calculator().CalculateShicht(ShichtMaterials.materials, 
            //    MaterialManager.Current.GetByName(comboBox2.SelectedItem.ToString()));
            foreach(var a in ShichtMaterials.materials)
            {
                s += $"{a.Name} = {33}% \n";
            }
            richTextBox2.Text = s;
        }

        private void AddMaterial_Click(object sender, EventArgs e)
        {
            CreateMaterial();
        }

        private void CreateMaterial()
        {
            UIMaterials.Add(new UIMaterial(storage));
        }
    }
}
