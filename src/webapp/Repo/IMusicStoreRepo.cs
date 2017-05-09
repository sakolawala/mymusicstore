using System.Collections.Generic;
using MyMusicStore.Models;

namespace mymusicstore.Repo
{
    public interface IMusicStoreRepo
    {
        List<Album> GetAllAlbums(int? count = 0);

        List<Genre> GetAllGenre(int? count = 0);

        List<string> GetAllGenreByName(int? count = 0);
    }
}