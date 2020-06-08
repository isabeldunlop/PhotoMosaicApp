using System;

namespace PhotoMosaic
{
    class Program
    {
        static void Main(string[] args)
        {
            var _mosaicGenerator = new MosaicGenerator();

            var srcImage = "../test_image_4.jpg";
            var imageFolder = "../MosaicTiles";
    
            var _mosaic = _mosaicGenerator.Generate(srcImage,imageFolder );
            _mosaic.Image.Save(string.Format("../{0}.jpg", Guid.NewGuid().ToString("N")));
            _mosaic.Image.Dispose();
            
            Console.WriteLine("Press any key to exit.....");
            Console.ReadKey();
        }
    }
}