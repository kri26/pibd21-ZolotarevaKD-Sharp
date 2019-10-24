﻿using System;
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
    public partial class FormBoat : Form
    {
        private Boat boat;

        public FormBoat()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
            Graphics gr = Graphics.FromImage(bmp);
            boat.DrawBoat(gr);
            pictureBoxBoat.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Gray, rnd.Next(0, 4), rnd.Next(100, 200));
            boat.SetPosition( 10, 50, pictureBoxBoat.Width,
           pictureBoxBoat.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    boat.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    boat.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    boat.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    boat.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        
    }
}
