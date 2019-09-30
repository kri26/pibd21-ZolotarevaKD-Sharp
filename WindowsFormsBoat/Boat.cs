using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
    class Boat
    {
        /// Левая координата отрисовки
        private float _startPosX;
        
        /// Правая кооридната отрисовки 
        private float _startPosY;

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

        public int Windows { private set; get; }

        public int Capacity { private set; get; }


        public Boat (int maxSpeed, float weight, Color mainColor, Color dopColor, int windows, int capesity)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Windows = windows;
            Capacity = capesity;
        }        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawBoat(Graphics g)
        {
            Brush brM = new SolidBrush(MainColor);
            g.FillRectangle(brM, _startPosX + 20, _startPosY + 10, 50, 30);

            Brush brD = new SolidBrush(DopColor);
            g.FillEllipse(brD, _startPosX, _startPosY + 30, 90, 20);
            g.FillRectangle(brD, _startPosX + 30, _startPosY, 10, 10);

            Brush brYelloy = new SolidBrush(Color.Yellow);

            switch (Windows)
            {
                case 0:
                    break;
                case 1:
                    g.FillEllipse(brYelloy, _startPosX + 40, _startPosY + 35, 10, 10);
                    break;
                case 2:
                    g.FillEllipse(brYelloy, _startPosX + 10, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 70, _startPosY + 35, 10, 10);
                    break;
                case 3:
                    g.FillEllipse(brYelloy, _startPosX + 10, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 40, _startPosY + 35, 10, 10);
                    g.FillEllipse(brYelloy, _startPosX + 70, _startPosY + 35, 10, 10);
                    break;
            }
        }
    }
}
