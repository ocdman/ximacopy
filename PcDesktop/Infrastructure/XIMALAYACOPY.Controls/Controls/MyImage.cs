using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace XIMALAYACOPY.Controls
{
    [TemplatePart(Name="PART_Image", Type=typeof(Image))]
    public class MyImage : Label
    {
        /// <summary>
        /// 图片的路径
        /// </summary>
        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(MyImage), new PropertyMetadata(null, OnSourceChanged));

        private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 图片的默认路径
        /// </summary>
        public string DefaultSource
        {
            get { return (string)GetValue(DefaultSourceProperty); }
            set { SetValue(DefaultSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DefaultSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefaultSourceProperty =
            DependencyProperty.Register("DefaultSource", typeof(string), typeof(MyImage), new PropertyMetadata(string.Empty, OnDefaultImageChanged));

        private static void OnDefaultImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/XIMALAYACOPY.Tools;component/Resources/Images/Defaults/" + e.NewValue.ToString(), UriKind.RelativeOrAbsolute);

            ImageBrush ib = new ImageBrush(new BitmapImage(uri));
            d.SetValue(Control.BackgroundProperty, ib);
        }

        private Image Image { get; set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.Image = GetTemplateChild("PART_Image") as Image;
        }


        
    }
}
