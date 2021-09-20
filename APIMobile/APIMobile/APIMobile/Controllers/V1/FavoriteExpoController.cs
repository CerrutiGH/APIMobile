using APIMobile.Connection;
using APIMobile.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIMobile.Controllers.V1
{
    public class FavoriteExpoController : ApiController
    {
        FavoriteExpoRequestsAPI FavAPI = new FavoriteExpoRequestsAPI();

        [HttpGet]
        [ActionName("getExpoFavorite")]
        public ExpoFavorite Get(int id)
        {
            var ex = FavAPI.MgetfavExpoById(id);
            if (ex == null)
            {
                var callback = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(callback);
            }
            return ex;
        }


        [HttpGet]
        [ActionName("getAllExpoFavorite")]
        public IEnumerable GetAllUsers()
        {
            return FavAPI.MgetfavExpo();
        }


        [HttpPost]
        [ActionName("addExpoFavorite")]
        public void Post([FromBody] ExpoFavorite ExpoFav)
        {
            FavAPI.InsertFavExpo(ExpoFav);
        }

        [HttpDelete]
        [ActionName("deleteExpoFavorite")]
        public void DeleteExpoFavorite(int id)
        {
            FavAPI.DeleteExpoFav(id);
        }



        [HttpPut]
        [ActionName("updateItem")]
        public void UpdateExpoFavorite(int id, [FromBody] ExpoFavorite FavExpo)
        {
            FavAPI.UpdateExpoFav(id, FavExpo);
        }
    }
}