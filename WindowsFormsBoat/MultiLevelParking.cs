﻿using System;
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
        /*
public bool SaveData(string filename)
{
  if (File.Exists(filename))
  {
      File.Delete(filename);
  }
  using (FileStream fs = new FileStream(filename, FileMode.Create))
  {
      //Записываем количество уровней
      WriteToFile("CountLeveles:" + parkingStages.Count +
     Environment.NewLine, fs);
      foreach (var level in parkingStages)
      {
          //Начинаем уровень
          WriteToFile("Level" + Environment.NewLine, fs);
          for (int i = 0; i < countPlaces; i++)
          {
              var boat = level[i];
              if (boat != null)
              {
                  //если место не пустое
                  //Записываем тип мшаины
                  if (boat.GetType().Name == "Boat")
                  {
                      WriteToFile(i + ":Boat:", fs);
                  }
                  if (boat.GetType().Name == "SportBoat")
                  {
                      WriteToFile(i + ":SportBoat:", fs);
                  }
                  //Записываемые параметры
                  WriteToFile(boat + Environment.NewLine, fs);
              }
          }
      }
  }
  return true;
}
/// <summary>
/// Метод записи информации в файл
/// </summary>
/// <param name="text">Строка, которую следует записать</param>
/// <param name="stream">Поток для записи</param>
private void WriteToFile(string text, FileStream stream)
{
  byte[] info = new UTF8Encoding(true).GetBytes(text);
  stream.Write(info, 0, info.Length);
}

public bool LoadData(string filename)
{
  if (!File.Exists(filename))
  {
      return false;
  }
  string bufferTextFromFile = "";
  using (FileStream fs = new FileStream(filename, FileMode.Open))
  {
      byte[] b = new byte[fs.Length];
      UTF8Encoding temp = new UTF8Encoding(true);
      while (fs.Read(b, 0, b.Length) > 0)
      {
          bufferTextFromFile += temp.GetString(b);
      }
  }
  bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
  var strs = bufferTextFromFile.Split('\n');
  if (strs[0].Contains("CountLeveles"))
  {
      //считываем количество уровней
      int count = Convert.ToInt32(strs[0].Split(':')[1]);
      if (parkingStages != null)
      {
          parkingStages.Clear();
      }
      parkingStages = new List<Parking<ITransport>>(count);
  }
  else
  {
      //если нет такой записи, то это не те данные
      return false;
  }
  int counter = -1;
  ITransport boat = null;
  for (int i = 1; i < strs.Length; ++i)
  {
      //идем по считанным записям
      if (strs[i] == "Level")
      {
          //начинаем новый уровень
          counter++;
          parkingStages.Add(new Parking<ITransport>(countPlaces,
              pictureWidth, pictureHeight));
          continue;
      }
      if (string.IsNullOrEmpty(strs[i]))
      {
          continue;
      }
      if (strs[i].Split(':')[1] == "Boat")
      {
          boat = new Boat(strs[i].Split(':')[2]);
      }
      else if (strs[i].Split(':')[1] == "SportBoat")
      {
          boat = new SportBoat(strs[i].Split(':')[2]);
      }
      parkingStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = boat;
  }
  return true;
}*/

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
                return false;
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
                    return false;
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
