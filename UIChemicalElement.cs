using System;
using System.Windows.Forms;

namespace CalculationChargeSmelting
{
    public class UIChemicalElement
    {
        public string Name => _name.Text;
        public int Percent => (int)_percent.Value;

        private TextBox _name;
        private NumericUpDown _percent;
        private Button _delete;
        private FlowLayoutPanel _parent;

        public UIChemicalElement(FlowLayoutPanel parent)
        {
            _name = new TextBox { Width = 175, Height = 25};
            _percent = new NumericUpDown { Width = 135, Height = 25 };
            _delete = new Button { Width = 25, Height = 25, Text = "X" };

            _delete.Click += new EventHandler(Delete_Click);

            parent.Controls.Add(_name);
            parent.Controls.Add(_percent);
            parent.Controls.Add(_delete);
            _parent = parent;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            _parent.Controls.Remove(_name);
            _parent.Controls.Remove(_percent);
            _parent.Controls.Remove(_delete);
        }
    }


}
