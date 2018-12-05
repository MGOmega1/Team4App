using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public ProfilePage()
        {
            InitializeComponent();
            employeePhoto.Source = "person.png";
            employeeName.Text = "This Guy";
            employeeDepartment.Text = "That Department";
            employeeID.Text = "0123456";

        }

        private void scheduleButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulePage());
        }
    }
}