using System;
using System.Windows.Forms;

namespace CalculationChargeSmelting
{
    public class UIMaterial
    {
        public string Name => _name.Text;
        public int Price => (int)_price.Value;
        public int Mass => (int)_mass.Value;

        private TextBox _name;
        private NumericUpDown _price;
        private NumericUpDown _mass;

        private Button _edit
            ;
        private Button _delete;

        private FlowLayoutPanel _parent;

        public UIMaterial(FlowLayoutPanel parent)
        {
            _name = new TextBox {Width=146,Height=25 };
            _price = new NumericUpDown { Width = 112, Height =25,Maximum=100000};
            _mass = new NumericUpDown { Width = 112, Height = 25, Maximum = 100000 };
            _edit = new Button { Width = 44, Height = 25, Text = "✏️" };
            _delete = new Button { Width = 22, Height = 25, Text = "X" };

            _delete.Click += new EventHandler(Delete_Click);
            _edit.Click += new EventHandler(Edit_Click);

            parent.Controls.Add(_name);
            parent.Controls.Add(_price);
            parent.Controls.Add(_mass);
            parent.Controls.Add(_edit);
            parent.Controls.Add(_delete);
            _parent = parent;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            _parent.Controls.Remove(_name);
            _parent.Controls.Remove(_price);
            _parent.Controls.Remove(_mass);
            _parent.Controls.Remove(_edit);
            _parent.Controls.Remove(_delete);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var creator = new materialCreator(Name);
            creator.Show();
        }
    }
}
