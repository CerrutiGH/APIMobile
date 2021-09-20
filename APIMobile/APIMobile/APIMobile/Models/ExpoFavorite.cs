using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIMobile.Models
{
    public class ExpoFavorite
    {
        public ExpoFavorite()
        {

        }

        public ExpoFavorite(int idExpo, int idUser)
        {
            IdExpo = idExpo;
            IdUser = idUser;
        }

        public int IdExpo { get; set; }
        public int IdUser { get; set; }
    }
}