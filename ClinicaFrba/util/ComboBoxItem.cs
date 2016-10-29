using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.util
{
    class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(int value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
