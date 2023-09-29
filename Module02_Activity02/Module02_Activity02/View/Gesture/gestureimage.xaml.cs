using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Module02_Activity02.View.Gesture
{	
	public partial class gestureimage : ContentPage
	{	
		public gestureimage ()
		{
			InitializeComponent ();
		}

        async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Correct", "You are absolutely right!", "Very good :)");
        }

        async void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;    
        }
    }
}

