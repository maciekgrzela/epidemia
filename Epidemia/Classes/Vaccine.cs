using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemia.Classes
{
    class Vaccine
    {
        public Guid identifier { get; set; }
        public bool isEffective { get; set; }
        public int protectionTime { get; set; }
        public Button button { get; set; }

        public Vaccine(bool isEffective)
        {
            this.identifier = Guid.NewGuid();
            this.isEffective = isEffective;
            initiateButton();
        }

        private void initiateButton()
        {
            this.button = new Button();
            this.button.Text = "";
            this.button.BackgroundImage = Properties.Resources._028_vaccine;
            this.button.Width = 50;
            this.button.Height = 50;
            this.button.FlatStyle = FlatStyle.Flat;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.Dock = DockStyle.Fill;
            this.button.BackgroundImageLayout = ImageLayout.Center;
            this.button.Name = this.identifier.ToString();
            Epidemia.Form.Invoke(new Action(() => Epidemia.Form.vaccinesTable.Controls.Add(this.button)));
        }
    }
}
