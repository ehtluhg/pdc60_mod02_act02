using System;
using System.Collections.Generic;
using Module02_Activity02.ViewModel;
using Xamarin.Forms;

namespace Module02_Activity02.View
{	
	public partial class Compass : ContentPage
	{	
		public Compass ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
			if (!DesignMode.IsDesignModeEnabled)
				((MyCompassViewModel)BindingContext).StartCommand.Execute (null);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StopCommand.Execute (null);
        }
    }
}

