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
		public ObservableCollection<Profile> employeeProfile { get; set; }
        public ProfilePage()
		{
			InitializeComponent ();
            profilePicture.Source = "profile.png";

            this.employeeProfile = new ObservableCollection<Profile>();
            this.employeeProfile.Add(new Profile { employeeName = "This Guy", employeeDepartment="That Department", employeeID = "0123456" });
            this.ProfileListView.ItemsSource = this.employeeProfile;

        }

        private void ProfileListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
    public class Profile
    {
        public string employeeName { get; set; }
        public string employeeDepartment { get; set; }
        public string employeeID { get; set; }
    }
}