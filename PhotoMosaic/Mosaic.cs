using System.Collections.Generic;
using System.Drawing;

namespace PhotoMosaic
{
    public class Mosaic
    {
        public Image Image { get; set; }
        public List<MosaicTile> Tiles { get; set; }
    }
}