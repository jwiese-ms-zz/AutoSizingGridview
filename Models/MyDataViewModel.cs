using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewAutoSizeSample.Models
{
    public class MyDataViewModel
    {
        public List<DataItem> Items { get; set; }

        public MyDataViewModel()
        {
            Items = new List<DataItem>();
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing1.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/1.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing2.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/2.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing3.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/3.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing4.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/4.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing5.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/5.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing6.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/6.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing7.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/7.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing8.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/8.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing9.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/9.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing10.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/10.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing11.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/11.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing12.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/12.png" });
            Items.Add(new DataItem() { BackgroundImage = "ms-appx:///Assets/Tiles/bing13.jpg", OverlayImage = "ms-appx:///Assets/TextOverlays/13.png" });
        }
    }
  
    public class DataItem
    {
        public string BackgroundImage { get; set; }
        public string OverlayImage { get; set; }
    }
    
}
