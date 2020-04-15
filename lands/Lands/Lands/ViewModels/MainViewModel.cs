namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModel
        public LoginViewModel login
        {
            get;
            set;
        }
        #endregion


        #region Constructors
        public MainViewModel()
        {
            this.login = new LoginViewModel();
        }

        #endregion



    }
}
