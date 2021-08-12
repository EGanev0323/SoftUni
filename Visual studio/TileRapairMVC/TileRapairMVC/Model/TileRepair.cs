using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRapairMVC.Model
{
    public class TileRepair
    {
        const double TIME = 0.2;

        private int sideA;
        private double widthTile;
        private double lengthTile;
        private int widthBench;
        private int lengthBench;

        public int SideA { get; set; }
        public double WidthTile { get; set; }
        public double LengthTile { get; set; }
        public int WidthBench { get; set; }
        public int LengthBench { get; set; }

        public TileRepair(int sideA, double widthTile, double lengthTile, int widthBench, int lengthBench)
        {
            this.SideA = sideA;
            this.WidthTile = widthTile;
            this.LengthTile = lengthTile;
            this.WidthBench = widthBench;
            this.LengthBench = lengthBench;
        }
        public TileRepair() : this(0, 0.0, 0.0, 0, 0)
        { }
        public double Tiles()
        {
             return (SideA* SideA - WidthBench* LengthBench)/(WidthTile* LengthTile);
        }
        public double CalculateTileCount()
        {
            return ((SideA * SideA - WidthBench * LengthBench)/(WidthTile*LengthTile))*TIME;
        }
    }
}
