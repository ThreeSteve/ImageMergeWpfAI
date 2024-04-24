using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

using static System.Net.Mime.MediaTypeNames;

namespace ImageCombination
{
    public partial class MainWindow : Window
    {
        public static FileInfo month01 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_JAN.png");
        public static FileInfo month02 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_FEB.png");
        public static FileInfo month03 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_MAR.png");
        public static FileInfo month04 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_APR.png");
        public static FileInfo month05 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_MAY.png");
        public static FileInfo month06 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_JUN.png");
        public static FileInfo month07 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_JUL.png");
        public static FileInfo month08 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_AUG.png");
        public static FileInfo month09 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_SEP.png");
        public static FileInfo month10 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_OCT.png");
        public static FileInfo month11 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_NOV.png");
        public static FileInfo month12 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Months\Cal_DEC.png");



        public static FileInfo pair01 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_DEC_JAN.png");
        public static FileInfo pair02 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_JAN_FEB.png");
        public static FileInfo pair03 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_FEB_MAR.png");
        public static FileInfo pair04 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_MAR_APR.png");
        public static FileInfo pair05 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_APR_MAY.png");
        public static FileInfo pair06 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_MAY_JUN.png");
        public static FileInfo pair07 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_JUN_JUL.png");
        public static FileInfo pair08 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_JUL_AUG.png");
        public static FileInfo pair09 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_AUG_SEP.png");
        public static FileInfo pair10 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_SEP_OCT.png");
        public static FileInfo pair11 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_OCT_NOV.png");
        public static FileInfo pair12 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Pairs\Cal_NOV_DEC.png");



        public static FileInfo flag01 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\USA.png");
        public static FileInfo flag02 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\SWE.png");
        public static FileInfo flag03 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\NZL.png");
        public static FileInfo flag04 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\NLD.png");
        public static FileInfo flag05 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\JPN.png");
        public static FileInfo flag06 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\ITA.png");
        public static FileInfo flag07 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\GBR.png");
        public static FileInfo flag08 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\FRA.png");
        public static FileInfo flag09 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\EUR.png");
        public static FileInfo flag10 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\ESP.png");
        public static FileInfo flag11 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\DNK.png");
        public static FileInfo flag12 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flags1\DEU.png");
        public static FileInfo flag13 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flasg2\CAN.png");
        public static FileInfo flag14 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flasg2\BEL.png");
        public static FileInfo flag15 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Flasg2\AUS.png");


        public static FileInfo timeDelta01 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\TimeDelta\DeltaChange_0_1.png");
        public static FileInfo timeDelta02 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\TimeDelta\DeltaChange_0_2.png");
        public static FileInfo timeDelta03 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\TimeDelta\DeltaChange_0_3.png");
        public static FileInfo timeDelta04 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\TimeDelta\DeltaChange_1_2.png");
        public static FileInfo timeDelta05 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\TimeDelta\DeltaChange_1_3.png");
        public static FileInfo timeDelta06 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\TimeDelta\DeltaChange_2_3.png");
        public static FileInfo time01 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Time\T0.png");
        public static FileInfo time02 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Time\T1.png");
        public static FileInfo time03 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Time\T2.png");
        public static FileInfo time04 = new FileInfo(@"C:\RiskEvo2024\ImagesGoldenNew\Time\T3.png");





        public MainWindow()
        {
            InitializeComponent();

            Dictionary<string, List<FileInfo>> imagePaths = new Dictionary<string, List<FileInfo>>()
            {
                { "Months",     new List<FileInfo>() { month01, month02, month03, month04, month05, month06, month07, month08, month09, month10, month11, month12 } },
                { "MonthPairs", new List<FileInfo>() { pair01, pair02, pair03, pair04, pair05, pair06, pair07, pair08, pair09, pair10, pair11, pair12 } },
                { "Flags1",     new List<FileInfo>() { flag01, flag02, flag03, flag04, flag05, flag06, flag07, flag08, flag09, flag10, flag11, flag12 } },
                { "Flags2",     new List<FileInfo>() { flag13, flag14, flag15 } },
                { "TimeDelta",  new List<FileInfo>() { timeDelta01, timeDelta02, timeDelta03, timeDelta04, timeDelta05, timeDelta06 } },
                { "Time",       new List<FileInfo>() { time01, time02, time03, time04 } },
            };

            (string, string) replace = ("CalGrey", "Cal");

            Dictionary<string, DirectoryInfo> outputPaths = new Dictionary<string, DirectoryInfo>()
            {
                { "Months",     new DirectoryInfo(@"C:\RiskEvo2024\ImagesGolden\Months") },
                { "MonthPairs", new DirectoryInfo(@"C:\RiskEvo2024\ImagesGolden\Pairs") },
                { "Flags1",     new DirectoryInfo(@"C:\RiskEvo2024\ImagesGolden\Flags1") },
                { "Flags2",     new DirectoryInfo(@"C:\RiskEvo2024\ImagesGolden\Flasg2") },
                { "TimeDelta",  new DirectoryInfo(@"C:\RiskEvo2024\ImagesGolden\TimeDelta") },
                { "Time",       new DirectoryInfo(@"C:\RiskEvo2024\ImagesGolden\Time") },
            };

            //foreach (var row in imagePaths)
            //{
            //    int x = 0;
            //    foreach (var item in row.Value)
            //    {
            //        string sourcePath= item.FullName;

            //        string outDir = outputPaths[row.Key].FullName;

            //        if (!Directory.Exists(outDir))
            //        {
            //            Directory.CreateDirectory(outDir);
            //        }

            //        string desPath = Path.Combine( outputPaths[row.Key].FullName, item.Name.Replace(replace.Item1, replace.Item2));

            //        File.Copy(sourcePath, desPath, true);
            //    }
            //}


            CombineImages(imagePaths);
        }

        private void CombineImages(Dictionary<string, List<FileInfo>> imagePaths)
        {
            // Create a bitmap to hold the combined image
            Bitmap combinedBitmap = new Bitmap(80 * 12, 80 * 6);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(combinedBitmap);
            g.Clear(System.Drawing.Color.Transparent);

            int y = 0;

            foreach (var row in imagePaths.Values) 
            {
                int x = 0;
                foreach (var item in row)
                { 
                    // Load each image
                    string imagePath = item.FullName; // Assuming images are PNG
                    Bitmap image = new Bitmap(imagePath);

                    // Draw the image onto the combined bitmap
                    g.DrawImage(image, x, y, image.Width, image.Height);

                    x += 80; // Move to the next position
                    image.Dispose();
                }
                y += 80;
            }

            g.Dispose();

            // Save the combined bitmap as PNG
            string outputPath = @"C:\RiskEvo2024\HTMLZ\combined_image5.png";
            combinedBitmap.Save(outputPath, ImageFormat.Png);

            // Convert the combined bitmap to BitmapSource
            BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                combinedBitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            // Set the combined image to the Image control
            combinedImage.Source = bitmapSource;
        }
    }
}
