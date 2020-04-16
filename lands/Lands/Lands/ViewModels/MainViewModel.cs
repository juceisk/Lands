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

        public LandsViewModel Lands
        {
            get;
            set;
        }

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.login = new LoginViewModel();
        }

        #endregion

        #region Singleton

        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {

            return new MainViewModel();
            }

            return instance;
        }
      
        #endregion

    }
}
