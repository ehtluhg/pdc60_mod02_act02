using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Module02_Activity02.View.Gesture
{	
	public partial class gesture : ContentPage
	{	
		public gesture ()
		{
			InitializeComponent ();
		}

		private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
		{
			var label = (sender as Element)?.Parent as Label;
			e.Data.Properties.Add("Text", label.Text);
		}

		private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
		{
			var data = e.Data.Properties["Text"].ToString();
			var frame = (sender as Element)?.Parent as Frame;
			frame.Content = new Label
			{ Text = data };
        }
    }
}

