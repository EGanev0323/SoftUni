using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRapairMVC.View
{
    public class Display
    {
        public int SideA { get; set; }
        public double WidthTile { get; set; }
        public double LengthTile { get; set; }
        public int WidthBench { get; set; }
        public int LengthBench { get; set; }
        public double Tiles { get; set; }
        public double CalculateTileCount { get; set; }

        public Display()
        {
            SideA = 0;
            WidthTile = 0.0;
            LengthTile = 0.0;
            WidthBench = 0;
            LengthBench = 0;
            GetValueKeyBoard();
        }
        private void GetValueKeyBoard()
        {
            Console.Write($"SideA= ");
            SideA = int.Parse(Console.ReadLine());
            Console.Write($"WidthTile= ");
            WidthTile = double.Parse(Console.ReadLine());
            Console.Write($"LengthTile= ");
            LengthTile = double.Parse(Console.ReadLine());
            Console.Write($"WidthBench= ");
            WidthBench = int.Parse(Console.ReadLine());
            Console.Write($"LengthBench= ");
            LengthBench = int.Parse(Console.ReadLine());
        }

        public void ShowTile()
        {
            Console.WriteLine($"{Tiles}");
        }
        public void ShowWork()
        {
           
            Console.WriteLine($"{CalculateTileCount}");
        }
    }
}
