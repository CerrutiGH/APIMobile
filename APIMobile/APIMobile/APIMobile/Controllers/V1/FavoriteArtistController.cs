using APIMobile.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIMobile.Connection;

namespace APIMobile.Controllers.V1
{
    public class FavoriteArtistController : ApiController
    {

        FavoriteArtistRequestsAPI FavAPI = new FavoriteArtistRequestsAPI();     

        [HttpGet]
        [ActionName("getArtistFavorite")]
        public ArtistFavorite Get(int id)
        {
            var af = FavAPI.MgetfavArtById(id);
            if (af == null)
            {
                var callback = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(callback);
            }
            return af;
        }


        [HttpGet]
        [ActionName("getAllArtistFavorite")]
        public IEnumerable GetAllArtFav()
        {
            return FavAPI.MgetfavArt();
        }

        
        [HttpPost]
        [ActionName("addArtistFavorite")]
        public void Post ([FromBody] ArtistFavorite FavArt)
        {

            FavAPI.InsertFavArt(FavArt);
        }


        [HttpDelete]
        [ActionName("deleteArtistFavorite")]
        public void DeleteArtistFavorite(int id)
        {
            FavAPI.DeleteArtFav(id);
        }



        [HttpPut]
        [ActionName("updateItem")]
        public void UpdateArtistFavorite(int id, [FromBody] ArtistFavorite FavArt)
        {
            FavAPI.UpdateArtFav(id, FavArt);
        }
    }
}