using System;
using SwiftUI;
using static SwiftUI.Views;

namespace Xamarinsample
{
	public partial record HelloView : View
	{
		readonly State<int> clicks = new(0);

		public View Body => ViewBuilder.BuildBlock<Button<Text>, Text>(
			Button($"Clicked {clicks.Value} times",
				() => clicks.Value++
			), new Text("Test")
		);
	}
}
