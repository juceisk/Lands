

namespace Lands.ViewModels
{
    using Lands.Services;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using Xamarin.Forms;

    public class LandsViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion


        #region Attributes
        //Se usa en listview
        private ObservableCollection<Land> lands;
        #endregion

        #region Properties
        public ObservableCollection<Land> Lands
        {
            // Refrescar campos en pantalla
            get { return this.lands; }
            set { SetValue(ref this.lands, value); }
        }
        #endregion

        #region Constructors

        public LandsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadLands();

        }
        #endregion


        #region Methods
        private async void LoadLands()
        {
            //verificar conexion
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "Accept");
                //desapilar la navegacion
                //Equivale ir a la pagina atras
                await Application.Current.MainPage.Navigation.PopAsync();

                return;
            }

            var response = await this.apiService.GetList<Land>("https://restcountries.eu","/rest","/v2/all");
        
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            var list = (List<Land>)response.Result;
            this.lands = new ObservableCollection<Land>(list);
        }

        

        #endregion
    }
}