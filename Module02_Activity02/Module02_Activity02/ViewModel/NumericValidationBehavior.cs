using System;
using System.Collections.Generic;
using System.Text;
// Add these directives
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Module02_Activity02.ViewModel
{
    public class NumericValidationBehavior:Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;
        }
    }
}
