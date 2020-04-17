using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemia.Classes
{
    class Test
    {
        public Guid identifier { get; set; }
        public bool isPositive { get; set; }

        private Button button;

        public Test(bool isPositive)
        {
            this.isPositive = isPositive;
            initiateButton();
        }

        private void initiateButton()
        {
            this.button = new Button();
            this.button.Text = "";
            this.button.BackgroundImage = Properties.Resources._033_vaccine;
            this.button.Width = 50;
            this.button.Height = 50;
            this.button.FlatStyle = FlatStyle.Flat;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.Dock = DockStyle.Fill;
            this.button.BackgroundImageLayout = ImageLayout.Center;
            this.button.Name = this.identifier.ToString();
            Epidemia.Form.Invoke(new Action(() => Epidemia.Form.labTable.Controls.Add(this.button)));
        }
    }
}
