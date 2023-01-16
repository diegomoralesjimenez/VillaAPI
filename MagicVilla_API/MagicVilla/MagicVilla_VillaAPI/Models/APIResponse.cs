using System.Net;

namespace MagicVilla_VillaAPI.Models
{
    public class APIResponse{

        public HttpStatusCode StatusCode { get; set; }

        public bool IsSucess { get; set; } = true;

        public List<string> ErrorMessage { get; set; }
        public object Result { get; set; }
    }
}
