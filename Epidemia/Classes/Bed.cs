using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemia.Classes
{
    class Bed
    {

        public Guid identifier { get; set; }
        public bool hasRespirator { get; set; }
        public bool isOccupied { get; set; }
        public void recover(Human human) { }
        public Mutex mutex { get; set; }
        private Button button;

        public Bed(Guid identifier, bool hasRespirator, bool isOccupied)
        {
            this.identifier = identifier;
            this.hasRespirator = hasRespirator;
            this.isOccupied = isOccupied;
            this.mutex = new Mutex();
            initiateButton();
        }

        private void initiateButton()
        {
            this.button = new Button();
            this.button.Text = "";
            if (this.hasRespirator)
            {
                this.button.BackgroundImage = Properties.Resources._006_lungs;
            }
            else
            {
                this.button.BackgroundImage = Properties.Resources._041_hospital_bed1;
            }
            this.button.Width = 50;
            this.button.Height = 50;
            this.button.FlatStyle = FlatStyle.Flat;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.Dock = DockStyle.Fill;
            this.button.BackgroundImageLayout = ImageLayout.Center;
            this.button.Name = this.identifier.ToString();
            Epidemia.Form.Invoke(new Action(() => Epidemia.Form.bedsTable.Controls.Add(this.button)));
        }
    }
}
