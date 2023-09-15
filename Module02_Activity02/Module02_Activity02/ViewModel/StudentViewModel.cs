using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Module02_Activity02.Model;
using Xamarin.Forms;

namespace Module02_Activity02.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }

        public string SubjectCodeEntry { get; set; }
        public string SubjectCodeDisplay { get; set; }

        public string SubjectTitleEntry { get; set; }
        public string SubjectTitleDisplay { get; set; }

        public string SubjectUnitEntry { get; set; }
        public string SubjectUnitDisplay { get; set; }

        // 6. Add ViewModel
        public StudentViewModel() 
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student
                {
                    SubjectCode = SubjectCodeEntry
                };

                SubjectCodeDisplay = SubjectCodeEntry;
                SubjectTitleDisplay = SubjectTitleEntry;
                SubjectUnitDisplay = SubjectUnitEntry;

                // Occurs when changes have been made on the entry
                OnPropertyChanged(nameof(SubjectCodeDisplay));
                OnPropertyChanged(nameof(SubjectCodeEntry));

                OnPropertyChanged(nameof(SubjectTitleDisplay));
                OnPropertyChanged(nameof(SubjectTitleEntry));

                OnPropertyChanged(nameof(SubjectUnitDisplay));
                OnPropertyChanged(nameof(SubjectUnitEntry));
            });
        }

        // 1. Change from 'internal class' to 'class'
        // 2. Add 'using [PROJECT_NAME].Model;'
        // 3. Add 'INotifyPropertyChanged'
        // 4. Add interface:
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            // Will notify whether there are changes/interactions in the View/ViewModel
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            // 5. Add variable (line 12 onwards)
        }
    }
}
