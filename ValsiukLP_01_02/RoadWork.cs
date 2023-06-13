using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValsiukLP_01_02
{
    public class RoadWork
    {
        protected double Width { get; set; } //ширина дороги (м)
        protected double Lenght { get; set; } //длинна (м)
        protected double Weight { get; set; } //масса дорожного покрытия на 1кв.м

        public RoadWork (double width, double lenght, double weight) 
        {
            if (width <= 0 && lenght <= 0 && weight <= 0) throw new ArgumentException("Значение не может юыть отрицательным");

            Width = width;
            Lenght = lenght;
            Weight = weight;
        }
        public virtual double GetQuality () 
        {
            return Width * Lenght * Weight / 1000; //качество работы по формуле данной в задании 
        }
        public virtual void PrintInfo () 
        {
            Console.WriteLine("Работы по дороге:");
            Console.WriteLine("Ширина: {0}", Width);
            Console.WriteLine("Длинна: {0}", Lenght);
            Console.WriteLine("Масса дорожного покрытия на 1 кв.м: {0}", Weight);
            Console.WriteLine("Качество работы: {0}", GetQuality());
        }

    }
}
