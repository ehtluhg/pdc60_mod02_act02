using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Module02_Activity02.ViewModel;

namespace Module02_Activity02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            // 8. Add directives (using [PROJECT_NAME].ViewModel;)
            // Add binding context
            BindingContext = new StudentViewModel();
        }
    }
}