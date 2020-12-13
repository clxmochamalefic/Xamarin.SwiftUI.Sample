using System;
using System.ComponentModel;

using UIKit;
using SwiftUI;
using Foundation;

namespace Xamarinsample
{
    [DesignTimeVisible(true)]
    public partial class ViewController : UIHostingViewController
    {
        public ViewController() : base(new HelloView())
        {
        }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        // This allows us to call our default constructor when created from the storyboard.
        [Export("awakeAfterUsingCoder:")]
        public ViewController AwakeAfterUsingCoder(NSCoder coder)
            => new ViewController();
    }
}