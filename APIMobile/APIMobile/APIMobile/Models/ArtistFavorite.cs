using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIMobile.Models
{
    public class ArtistFavorite
    {
        public ArtistFavorite()
        {

        }

        public ArtistFavorite(int idArt, int idUser)
        {
            IdArt = idArt;
            IdUser = idUser;
        }


        public int IdArt { get; set; }
        public int IdUser { get; set; }

    }
}