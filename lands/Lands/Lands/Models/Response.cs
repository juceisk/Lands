
namespace Lands.Models
{
    public class Response
    {
        // fallo o fue exitoso
        public bool IsSuccess
        {
            get;
            set;
        }

        //mesaje de error 
        public string Message
        {
            get;
            set;
        }

        //devuelve lista de paises
        public object Result
        {
            get;
            set;
        }


    }
}
