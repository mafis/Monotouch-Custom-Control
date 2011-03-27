using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.Foundation;

namespace CustomControls
{

	public partial class CustomNavigationBar : UINavigationBar
	{
		
		//Die Standardkonstrutoren einfach durchgeben
		public CustomNavigationBar () : base()
		{
			
		}
		
		public CustomNavigationBar (NSCoder coder) : base(coder)
		{
			
		}
		
		public CustomNavigationBar (IntPtr ptr) : base(ptr)
		{
			
		}
		
		public CustomNavigationBar (NSObjectFlag t) : base(t)
		{
			
		}
		
		public CustomNavigationBar (RectangleF frame) : base(frame)
		{
			
		}
		
		public override void Draw (RectangleF rect)
		{
			base.Draw (rect);
			
			//Background zeichnen
			UIImage image = UIImage.FromBundle("NavigationBar.png");
			image.Draw(rect);
		}
	}
}

