using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
    public class SportBoat : Boat
    {
        /// Ширина окна отрисовки
        private int _pictureWidth;

        /// Высота окна отрисовки
        private int _pictureHeight;

        /// Ширина отрисовки 
        private const int boatWidth = 100;

        /// Ширина отрисовки 
        private const int boatHeight = 60;

        /// Максимальная скорость
        public int MaxSpeed { private set; get; }

        //
        public float Weight { private set; get; }

        /// Основной цвет 
        public Color MainColor { private set; get; }

        /// Дополнительный цвет
        public Color DopColor { private set; get; }

        public int _windows;

        public int Capacity { private set; get; }

        public int Windows
        {
            set
            {
                if (value > 0 && value < 4) _windows = value;
            }
            get { return _windows; }
        }


        public SportBoat(int maxSpeed, float weight, Color mainColor, Color dopColor, int capesity, int windows) :
            base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Windows = windows;
            Capacity = capesity;
        }

        public override void DrawBoat(Graphics g)
        {
            Brush brYelloy = new SolidBrush(Color.Yellow);
            Brush brDop = new SolidBrush(DopColor);
            Brush brM = new SolidBrush(MainColor);
            g.FillRectangle(brM, _startPosX + 20, _startPosY + 10, 50, 30);
            Brush brD = new SolidBrush(Color.Gray);
            base.DrawBoat(g);
            g.FillRectangle(brD, _startPosX + 30, _startPosY, 10, 10);

            switch (_windows)
            {
                case 0:
                    break;
                case 1:
                    g.FillEllipse(brDop, _startPosX, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 40, _startPosY + 35, 10, 10);
                    break;
                case 2:
                    g.FillEllipse(brDop, _startPosX - 10, _startPosY + 30, 15, 10);
                    g.FillEllipse(brDop, _startPosX - 10, _startPosY + 40, 15, 10);
                    g.FillEllipse(brYelloy, _startPosX + 10, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 70, _startPosY + 35, 10, 10);
                    break;
                case 3:
                    g.FillEllipse(brDop, _startPosX, _startPosY + 25, 11, 10);
                    g.FillEllipse(brDop, _startPosX, _startPosY + 35, 11, 10);
                    g.FillEllipse(brDop, _startPosX, _startPosY + 45, 11, 10);
                    g.FillEllipse(brYelloy, _startPosX + 10, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 40, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 70, _startPosY + 35, 10, 10);
                    break;
            }
        }
    }
}
