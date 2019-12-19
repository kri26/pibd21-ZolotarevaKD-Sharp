using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public class SportBoat : Boat, IComparable<SportBoat>, IEquatable<SportBoat>
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

        public SportBoat(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Windows = Convert.ToInt32(strs[4]);
                Capacity = Convert.ToInt32(strs[5]);
            }
        }
        public override void DrawBoat(Graphics g)
        {
            Brush brYelloy = new SolidBrush(Color.Yellow);

            Brush brDop = new SolidBrush(DopColor);

            Brush brM = new SolidBrush(Color.Black);
            g.FillRectangle(brM, _startPosX + 20, _startPosY + 10, 50, 30);
            Brush brD = new SolidBrush(Color.Gray);
            base.DrawBoat(g);
            Brush brMain = new SolidBrush(MainColor);
            g.FillEllipse(brMain, _startPosX, _startPosY + 30, 90, 20);


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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
           return base.ToString() + ";" + DopColor.Name + ";" + Windows + ";" +
                Capacity;
        }

        public int CompareTo(SportBoat other)
        {
            var res = (this is Boat).CompareTo(other is Boat);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Windows != other.Windows)
            {
                return Windows.CompareTo(other.Windows);
            }
            return 0;
        }

        public bool Equals(SportBoat other)
        {
            var res = (this as Boat).Equals(other as Boat);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Windows != other.Windows)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is SportBoat boatObj))
            {
                return false;
            }
            else
            {
                return Equals(boatObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
