using System;
using System.Windows.Forms;

namespace CalculationChargeSmelting
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        private void shichtType_SelectedIndexChanged(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e)
        {
            var creator = new materialCreator();
            creator.Show();
        }

        public Materials ShichtMaterials = new Materials();

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialManager.Load();
        }

        private void LoadMaterials_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            MaterialManager.LoadInternal();
            foreach (var mat in MaterialManager.Current.materials)
            {
                comboBox1.Items.Add(mat.ToString());
                comboBox2.Items.Add(mat.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            var newMat = MaterialManager.Current.GetByName(comboBox1.SelectedItem.ToString());
            if (newMat == null)
                return;
            if (ShichtMaterials.materials.Contains(newMat))
                return;
            ShichtMaterials.materials.Add(newMat);
            UpdateShichtMaterials();
        }

        private void UpdateShichtMaterials()
        {
            var s = "";
            foreach(var mat in ShichtMaterials.materials)
            {
                s += mat.ToString() + "\n\n";
            }
            richTextBox1.Text = s;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveMaterial_Click(object sender, EventArgs e)
        {
            var newMat = MaterialManager.Current.GetByName(comboBox1.SelectedItem.ToString());
            if (newMat == null)
                return;
            if (!ShichtMaterials.materials.Contains(newMat))
                return;
            ShichtMaterials.materials.Remove(newMat);
            UpdateShichtMaterials();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
