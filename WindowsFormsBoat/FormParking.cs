using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
            pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, dialog.Color);
                int place = parking + boat;
                Draw();
            }
        }

        private void buttonSetSportBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var boat = new SportBoat(100, 1000, dialog.Color, dialogDop.Color,
                   1, 1);
                    int place = parking + boat;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var boat = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (boat != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBoat.Width,
                   pictureBoxTakeBoat.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    boat.SetPosition(5, 5, pictureBoxTakeBoat.Width,
                   pictureBoxTakeBoat.Height);
                    boat.DrawBoat(gr);
                    pictureBoxTakeBoat.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBoat.Width,
                   pictureBoxTakeBoat.Height);
                    pictureBoxTakeBoat.Image = bmp;
                }
                Draw();
            }
        }
    }
}
