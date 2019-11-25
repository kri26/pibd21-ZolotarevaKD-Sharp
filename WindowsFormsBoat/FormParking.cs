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
        MultiLevelParking parking;
        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;

        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking[listBoxLevels.SelectedIndex].Draw(gr);
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
                int place = parking[listBoxLevels.SelectedIndex] + boat;
                if (place == -1)
                {
                    MessageBox.Show("Нет свободных мест", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    int place = parking[listBoxLevels.SelectedIndex] + boat;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            if (maskedTextBoxPosition.Text != "")
            {
                var boat = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPosition.Text);
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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
