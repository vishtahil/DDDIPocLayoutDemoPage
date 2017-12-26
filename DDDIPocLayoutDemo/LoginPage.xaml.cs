using Xamarin.Forms;

namespace DDDIPocLayoutDemo
{
    public partial class LoginPage : ContentPage
    {
        void onPageSizeChanged(object sender, System.EventArgs e)
        {
            if (Device.Idiom == TargetIdiom.Phone)
            {
                if (Width < Height)
                { //portrait mode
                    parentLoginGrid.Margin = new Thickness(0, 70, 0, 0);
                    parentLoginGrid.ColumnDefinitions[1].Width = new GridLength(300, GridUnitType.Absolute);

                }
                else
                { //landscape mode
                    parentLoginGrid.Margin = new Thickness(0, 0, 0, 0);
                    parentLoginGrid.ColumnDefinitions[1].Width = new GridLength(400, GridUnitType.Absolute);
                }
            }
            else //tablet mode
            {
                parentLoginGrid.Margin = new Thickness(0, 70, 0, 0);
                parentLoginGrid.ColumnDefinitions[1].Width = new GridLength(400, GridUnitType.Absolute);
            }
        }


        public LoginPage()
        {
            InitializeComponent();
            this.txtPassword.Placeholder = "Password";
            this.txtUserName.Placeholder = "User Name";

        }



    }
}
