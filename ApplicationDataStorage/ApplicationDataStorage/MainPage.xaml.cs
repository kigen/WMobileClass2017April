using System;
using System.IO;
using System.Runtime.Serialization.Json;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ApplicationDataStorage.Common;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace ApplicationDataStorage
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ObservableDictionary defaultViewModel = new ObservableDictionary();

        private readonly ApplicationDataContainer localSettings =
            ApplicationData.Current.LocalSettings;

        private readonly ApplicationDataContainer roamingSettings =
            ApplicationData.Current.RoamingSettings;

        public MainPage()
        {
            InitializeComponent();

            NavigationHelper = new NavigationHelper(this);
            NavigationHelper.LoadState += NavigationHelper_LoadState;
            NavigationHelper.SaveState += NavigationHelper_SaveState;
        }

        /// <summary>
        ///     Gets the <see cref="NavigationHelper" /> associated with this <see cref="Page" />.
        /// </summary>
        public NavigationHelper NavigationHelper { get; private set; }

        /// <summary>
        ///     Gets the view model for this <see cref="Page" />.
        ///     This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return defaultViewModel; }
        }

        /// <summary>
        ///     Populates the page with content passed during navigation.  Any saved state is also
        ///     provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        ///     The source of the event; typically <see cref="NavigationHelper" />
        /// </param>
        /// <param name="e">
        ///     Event data that provides both the navigation parameter passed to
        ///     <see cref="Frame.Navigate(Type, Object)" /> when this page was initially requested and
        ///     a dictionary of state preserved by this page during an earlier
        ///     session.  The state will be null the first time a page is visited.
        /// </param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        ///     Preserves state associated with this page in case the application is suspended or the
        ///     page is discarded from the navigation cache.  Values must conform to the serialization
        ///     requirements of <see cref="SuspensionManager.SessionState" />.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper" /></param>
        /// <param name="e">
        ///     Event data that provides an empty dictionary to be populated with
        ///     serializable state.
        /// </param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        ///     The methods provided in this section are simply used to allow
        ///     NavigationHelper to respond to the page's navigation methods.
        ///     <para>
        ///         Page specific logic should be placed in event handlers for the
        ///         <see cref="NavigationHelper.LoadState" />
        ///         and <see cref="NavigationHelper.SaveState" />.
        ///         The navigation parameter is available in the LoadState method
        ///         in addition to page state preserved during an earlier session.
        ///     </para>
        /// </summary>
        /// <param name="e">
        ///     Provides data for navigation methods and event
        ///     handlers that cannot cancel the navigation request.
        /// </param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NavigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            NavigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void btnSaveLocal_Click(object sender, RoutedEventArgs e)
        {
            //Simple values 
            localSettings.Values["name"] = txtInput.Text;
            roamingSettings.Values["name"] = txtInput.Text;

            Student student = new Student();
            student.Name = txtInput.Text;
            student.Class = txtInputClass.Text;
            //1. Convert student obj to JSON ---> String 
            //2. Save JSON string to Settings. 
            localSettings.Values["student"] = "";
            
        }


        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            //Reading simple values...
            tbLocal.Text = localSettings.Values["name"].ToString();
            tbRoaming.Text = roamingSettings.Values["name"].ToString();
        }

        private void btnReadRoaming_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReadLocal_Click(object sender, RoutedEventArgs e)
        {
            Student student = localSettings.Values["student"] as Student;
            if (student != null)
            {
                tbLocal.Text = "Name :" + student.Name;
                tbRoaming.Text = "Name :" + student.Class;
            }
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }

    }
}