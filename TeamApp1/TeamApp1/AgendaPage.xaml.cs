using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamApp1
{
    public partial class AgendaPage : ContentPage
    {
        public ObservableCollection<Week> Time { get; set; }

        public AgendaPage()
        {
            InitializeComponent();

            this.Time = new ObservableCollection<Week>();

            this.Time.Add(new Week
            { Day = "- Monday -" });
            this.Time.Add(new Week
            { Day = "- Tuesday -" });
            this.Time.Add(new Week
            { Day = "- Wednesday -" });
            this.Time.Add(new Week
            { Day = "- Thursday -" });
            this.Time.Add(new Week
            { Day = "- Friday -" });

            AgendaListView.ItemsSource = this.Time;
        }

        private void AgendaListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            Week selectedWeek = e.SelectedItem as Week;

            (sender as ListView).SelectedItem = null;

            DisplayAlert("Hi", "You Tapped " + selectedWeek.Day, "Ok");
        }

        public class Week
        {
            public string Day { get; set; }
        }
	}
}