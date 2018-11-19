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
        public PastHoursPage(string Monday, string Tuesday, string Wednesday, string Thursday, string Friday)
        {
            InitializeComponent();

            this.Hours = new ObservableCollection<Hour>();
            this.Hours.Add(new Hour
            { Days = "Monday: ", Hours = Convert.ToDecimal(Monday) });
            this.Hours.Add(new Hour
            { Days = "Tuesday: ", Hours = Convert.ToDecimal(Tuesday) });
            this.Hours.Add(new Hour
            { Days = "Wednesday: ", Hours = Convert.ToDecimal(Wednesday) });
            this.Hours.Add(new Hour
            { Days = "Thursday: ", Hours = Convert.ToDecimal(Thursday) });
            this.Hours.Add(new Hour
            { Days = "Friday: ", Hours = Convert.ToDecimal(Friday) });

            hoursListView.ItemsSource = this.Hours;

            decimal Total = this.Hours.Sum(x => x.Hours);
            totalHours.Text = Total.ToString();
        }


        public class Hour
        {

            public decimal Hours { get; set; }
            public string Days { get; set; }
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success!", "Thank you for approving your time", "Ok");
        }
    }
}

