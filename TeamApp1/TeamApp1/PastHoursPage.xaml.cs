using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PastHoursPage : ContentPage
    {
        public ObservableCollection<Hour> Hours { get; set; }
        public PastHoursPage()
        {
            InitializeComponent();

            this.Hours = new ObservableCollection<Hour>();
            this.Hours.Add(new Hour
            { Days = "Monday: ", Hours = 8 });
            this.Hours.Add(new Hour
            { Days = "Tuesday: ", Hours = 7.5m });
            this.Hours.Add(new Hour
            { Days = "Wednesday: ", Hours = 8.5m });
            this.Hours.Add(new Hour
            { Days = "Thursday: ", Hours = 8 });
            this.Hours.Add(new Hour
            { Days = "Friday: ", Hours = 8 });
            this.Hours.Add(new Hour
            { Days = "Hours worked last week: ", Hours = 40 });

            hoursListView.ItemsSource = this.Hours;
        }


        public class Hour
        {

            public decimal Hours { get; set; }
            public string Days { get; set; }
        }
    }
}

