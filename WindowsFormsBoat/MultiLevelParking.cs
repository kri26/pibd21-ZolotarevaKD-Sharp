using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
    class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;
        private Logger logger;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
               parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
                    pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var car = level[i];
                        if (car != null)
                        {
                            if (car.GetType().Name == "Boat")
                            {
                                sw.Write(i + ":Boat:");
                            }
                            if (car.GetType().Name == "SportBoat")
                            {
                                sw.Write(i + ":SportBoat:");
                            }
                            sw.WriteLine(car);
                        }
                    }
                }
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                logger.Error("Файл не найден");
                throw new FileNotFoundException();
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    logger.Error("Неверный формат файла");
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport boat = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "Boat")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        boat = new Boat(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "SportBoat")
                    {
                        boat = new SportBoat(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = boat;
                }
            }
            return true;
        }

    }

}
