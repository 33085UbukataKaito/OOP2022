using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace 卒業制作 {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private NavigationService _navi;
        public MainWindow() {
            InitializeComponent();
            
        }

        public  string id;

        string a;
        string b = "\n" + "\n";
        
        DateTime date = DateTime.Now;
        DateTime dateYesterday = DateTime.Today.AddDays(-1);

        private List<Uri> _uriList = new List<Uri>() {
            new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative),
            new Uri("Page3.xaml",UriKind.Relative),
        };



        private void Button_Click(object sender, RoutedEventArgs e) {

            tb1.Text = null;
            tb1a.Text = null;
            tb2.Text = null;
            tb2a.Text = null;
            tb3.Text = null;
            tb3a.Text = null;
            tb4.Text = null;
            tb4a.Text = null;
            tb5.Text = null;
            tb5a.Text = null;
            tb6.Text = null;
            tb6a.Text = null;
            tb7.Text = null;
            tb7a.Text = null;
            tb8.Text = null;
            tb8a.Text = null;
            tb9.Text = null;
            tb9a.Text = null;
            tb10.Text = null;
            tb10a.Text = null;
            tb11.Text = null;
            tb11a.Text = null;
            tb12.Text = null;
            tb12a.Text = null;


            picture.Source = null;
            picture2.Source = null;
            picture3.Source = null;
            picture4.Source = null;
            picture5.Source = null;
            picture6.Source = null;
            picture7.Source = null;
            picture8.Source = null;
            picture9.Source = null;
            picture10.Source = null;
            picture11.Source = null;
            picture12.Source = null;

            a = tbserch.Text;

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var serch = wc.DownloadString("https://api.search.nicovideo.jp/api/v2/snapshot/video/contents/search?q=" + a + "&targets=title&fields=contentId,title,viewCounter,description,thumbnailUrl&filters[viewCounter][gte]=10000&_sort=-viewCounter&_offset=0&_limit=12&_context=apiguide");

            var serch2 = wc.DownloadString("https://api.search.nicovideo.jp/api/v2/snapshot/video/contents/search?q=" + a + "&targets=title&fields=contentId,title,viewCounter&filters[viewCounter][gte]=10000&_sort=-viewCounter&_offset=0&_limit=12&_context=apiguide");

            

            var json = JsonConvert.DeserializeObject<Datum>(serch2);

            var json2 = JsonConvert.DeserializeObject<Rootobject1>(serch);

            
            
            Image image = new Image();
            

            
            BitmapImage imagesourse = new BitmapImage(new Uri(json2.data[0].thumbnailUrl));
            image.Source = imagesourse;
            picture.Source = image.Source;
            BitmapImage imagesourse2 = new BitmapImage(new Uri(json2.data[1].thumbnailUrl));
            image.Source = imagesourse2;
            picture2.Source = image.Source;
            BitmapImage imagesourse3 = new BitmapImage(new Uri(json2.data[2].thumbnailUrl));
            image.Source = imagesourse3;
            picture3.Source = image.Source;
            BitmapImage imagesourse4 = new BitmapImage(new Uri(json2.data[3].thumbnailUrl));
            image.Source = imagesourse4;
            picture4.Source = image.Source;
            BitmapImage imagesourse5 = new BitmapImage(new Uri(json2.data[4].thumbnailUrl));
            image.Source = imagesourse5;
            picture5.Source = image.Source;
            BitmapImage imagesourse6 = new BitmapImage(new Uri(json2.data[5].thumbnailUrl));
            image.Source = imagesourse6;
            picture6.Source = image.Source;
            BitmapImage imagesourse7 = new BitmapImage(new Uri(json2.data[6].thumbnailUrl));
            image.Source = imagesourse7;
            picture7.Source = image.Source;
            BitmapImage imagesourse8 = new BitmapImage(new Uri(json2.data[7].thumbnailUrl));
            image.Source = imagesourse8;
            picture8.Source = image.Source;
            BitmapImage imagesourse9 = new BitmapImage(new Uri(json2.data[8].thumbnailUrl));
            image.Source = imagesourse9;
            picture9.Source = image.Source;
            BitmapImage imagesourse10 = new BitmapImage(new Uri(json2.data[9].thumbnailUrl));
            image.Source = imagesourse10;
            picture10.Source = image.Source;
            BitmapImage imagesourse11 = new BitmapImage(new Uri(json2.data[10].thumbnailUrl));
            image.Source = imagesourse11;
            picture11.Source = image.Source;
            BitmapImage imagesourse12 = new BitmapImage(new Uri(json2.data[11].thumbnailUrl));
            image.Source = imagesourse12;
            picture12.Source = image.Source;


            tb1.Text = json2.data[0].title;
            tb1a.Text = json2.data[0].description;
            tb2.Text = json2.data[1].title;
            tb2a.Text = json2.data[1].description;
            tb3.Text = json2.data[2].title;
            tb3a.Text = json2.data[2].description;
            tb4.Text = json2.data[3].title;
            tb4a.Text = json2.data[3].description;
            tb5.Text = json2.data[4].title;
            tb5a.Text = json2.data[4].description;
            tb6.Text = json2.data[5].title;
            tb6a.Text = json2.data[5].description;
            tb7.Text = json2.data[6].title;
            tb7a.Text = json2.data[6].description;
            tb8.Text = json2.data[7].title;
            tb8a.Text = json2.data[7].description;
            tb9.Text = json2.data[8].title;
            tb9a.Text = json2.data[8].description;
            tb10.Text = json2.data[9].title;
            tb10a.Text = json2.data[9].description;
            tb11.Text = json2.data[10].title;
            tb11a.Text = json2.data[10].description;
            tb12.Text = json2.data[11].title;
            tb12a.Text = json2.data[11].description;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var serch = wc.DownloadString("https://api.search.nicovideo.jp/api/v2/snapshot/video/contents/search?q=初音ミク&targets=title&fields=contentId,title,viewCounter,description,thumbnailUrl&filters[viewCounter][gte]=10000&_sort=-viewCounter&_offset=0&_limit=12&_contentId&_context=apiguide");

            var serch2 = wc.DownloadString("https://api.search.nicovideo.jp/api/v2/snapshot/video/contents/search?q=初音ミク&targets=title&fields=contentId,title,viewCounter&filters[viewCounter][gte]=10000&_sort=-viewCounter&_offset=0&_limit=12&_contentId&_context=apiguide");

            

            

            var json = JsonConvert.DeserializeObject<Datum>(serch2);

            var json2 = JsonConvert.DeserializeObject<Rootobject1>(serch);

            

            xMl.Text = json2.data[0].contentId;


            Image image = new Image();
            BitmapImage imagesourse = new BitmapImage(new Uri(json2.data[0].thumbnailUrl));
            image.Source = imagesourse;
            picture.Source = image.Source;
            BitmapImage imagesourse2 = new BitmapImage(new Uri(json2.data[1].thumbnailUrl));
            image.Source = imagesourse2;
            picture2.Source = image.Source;
            BitmapImage imagesourse3 = new BitmapImage(new Uri(json2.data[2].thumbnailUrl));
            image.Source = imagesourse3;
            picture3.Source = image.Source;
            BitmapImage imagesourse4 = new BitmapImage(new Uri(json2.data[3].thumbnailUrl));
            image.Source = imagesourse4;
            picture4.Source = image.Source;
            BitmapImage imagesourse5 = new BitmapImage(new Uri(json2.data[4].thumbnailUrl));
            image.Source = imagesourse5;
            picture5.Source = image.Source;
            BitmapImage imagesourse6 = new BitmapImage(new Uri(json2.data[5].thumbnailUrl));
            image.Source = imagesourse6;
            picture6.Source = image.Source;
            BitmapImage imagesourse7 = new BitmapImage(new Uri(json2.data[6].thumbnailUrl));
            image.Source = imagesourse7;
            picture7.Source = image.Source;
            BitmapImage imagesourse8 = new BitmapImage(new Uri(json2.data[7].thumbnailUrl));
            image.Source = imagesourse8;
            picture8.Source = image.Source;
            BitmapImage imagesourse9 = new BitmapImage(new Uri(json2.data[8].thumbnailUrl));
            image.Source = imagesourse9;
            picture9.Source = image.Source;
            BitmapImage imagesourse10 = new BitmapImage(new Uri(json2.data[9].thumbnailUrl));
            image.Source = imagesourse10;
            picture10.Source = image.Source;
            BitmapImage imagesourse11 = new BitmapImage(new Uri(json2.data[10].thumbnailUrl));
            image.Source = imagesourse11;
            picture11.Source = image.Source;
            BitmapImage imagesourse12 = new BitmapImage(new Uri(json2.data[11].thumbnailUrl));
            image.Source = imagesourse12;
            picture12.Source = image.Source;



            tb1.Text = json2.data[0].title;
            tb1a.Text = json2.data[0].description;
            tb2.Text = json2.data[1].title;
            tb2a.Text = json2.data[1].description;
            tb3.Text = json2.data[2].title;
            tb3a.Text = json2.data[2].description;
            tb4.Text = json2.data[3].title;
            tb4a.Text = json2.data[3].description;
            tb5.Text = json2.data[4].title;
            tb5a.Text = json2.data[4].description;
            tb6.Text = json2.data[5].title;
            tb6a.Text = json2.data[5].description;
            tb7.Text = json2.data[6].title;
            tb7a.Text = json2.data[6].description;
            tb8.Text = json2.data[7].title;
            tb8a.Text = json2.data[7].description;
            tb9.Text = json2.data[8].title;
            tb9a.Text = json2.data[8].description;
            tb10.Text = json2.data[9].title;
            tb10a.Text = json2.data[9].description;
            tb11.Text = json2.data[10].title;
            tb11a.Text = json2.data[10].description;
            tb12.Text = json2.data[11].title;
            tb12a.Text = json2.data[11].description;


            var ssss = dateYesterday.ToString("yyyy-MM-dd");

            var ranking = wc.DownloadString("https://dcdn.cdn.nimg.jp/nicovideo/old-ranking/daily/" + ssss + "/all.json");

            var json3 = JsonConvert.DeserializeObject<Class1[]>(ranking);

            tbranc1.Text = "1." + json3[0].title;
            BitmapImage imageSourse = new BitmapImage(new Uri(json3[0].thumbnail.url));
            image.Source = imageSourse;
            picRanc1.Source = image.Source;

            tbranc2.Text = "2." + json3[1].title;
            BitmapImage imageSourse2 = new BitmapImage(new Uri(json3[1].thumbnail.url));
            image.Source = imageSourse2;
            picRanc2.Source = image.Source;

            tbranc3.Text = "3." + json3[2].title;
            BitmapImage imageSourse3 = new BitmapImage(new Uri(json3[2].thumbnail.url));
            image.Source = imageSourse3;
            picRanc3.Source = image.Source;

            tbranc4.Text = "4." + json3[3].title;
            BitmapImage imageSourse4 = new BitmapImage(new Uri(json3[3].thumbnail.url));
            image.Source = imageSourse4;
            picRanc4.Source = image.Source;

            tbranc5.Text = "5." + json3[4].title;
            BitmapImage imageSourse5 = new BitmapImage(new Uri(json3[4].thumbnail.url));
            image.Source = imageSourse5;
            picRanc5.Source = image.Source;

            tbranc6.Text = "6." + json3[5].title;
            BitmapImage imageSourse6 = new BitmapImage(new Uri(json3[5].thumbnail.url));
            image.Source = imageSourse6;
            picRanc6.Source = image.Source;

            tbranc7.Text = "7." + json3[6].title;
            BitmapImage imageSourse7 = new BitmapImage(new Uri(json3[6].thumbnail.url));
            image.Source = imageSourse7;
            picRanc7.Source = image.Source;

            tbranc8.Text = "8." + json3[7].title;
            BitmapImage imageSourse8 = new BitmapImage(new Uri(json3[7].thumbnail.url));
            image.Source = imageSourse8;
            picRanc8.Source = image.Source;

            tbranc9.Text = "9." + json3[8].title;
            BitmapImage imageSourse9 = new BitmapImage(new Uri(json3[8].thumbnail.url));
            image.Source = imageSourse9;
            picRanc9.Source = image.Source;

            tbranc10.Text = "10." + json3[9].title;
            BitmapImage imageSourse10 = new BitmapImage(new Uri(json3[9].thumbnail.url));
            image.Source = imageSourse10;
            picRanc10.Source = image.Source;

            //nikoniko.Text ="1." + json3[0].title  +  b + "2." +  json3[1].title + b + "3." + json3[2].title + b + "4." + json3[3].title
            //    + b + "5." + json3[4].title + b + "6." + json3[5].title + b + "7." + json3[6].title + b + "8." + json3[7].title
            //    + b + "9." + json3[8].title + b + "10." + json3[9].title;
        }

       

        public static void tb1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var serch = wc.DownloadString("https://api.search.nicovideo.jp/api/v2/snapshot/video/contents/search?q=初音ミク&targets=title&fields=contentId,title,viewCounter,description,thumbnailUrl&filters[viewCounter][gte]=10000&_sort=-viewCounter&_offset=0&_limit=12&_contentId&_context=apiguide");
            var json2 = JsonConvert.DeserializeObject<Rootobject1>(serch);

            var id = json2.data[0].contentId;

            Window1 sw = new Window1();
            sw.Show();
        }
    }
}
