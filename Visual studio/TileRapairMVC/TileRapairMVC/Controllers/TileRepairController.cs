using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileRapairMVC.Model;
using TileRapairMVC.View;

namespace TileRapairMVC.Controllers
{
    public class TileRepairController
    {
        private TileRepair tileRepair;
        private Display display;

        public TileRepairController()
        {
            display = new Display();
            tileRepair = new TileRepair(display.SideA, display.WidthTile, display.LengthTile, display.WidthBench, display.LengthBench);
            display.Tiles = tileRepair.Tiles();
            display.ShowTile();
            display.CalculateTileCount = tileRepair.CalculateTileCount();
            display.ShowWork();
            
        }
    }
}
