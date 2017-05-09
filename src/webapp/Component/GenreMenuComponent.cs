using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mymusicstore.Repo;

namespace MyMusicStore.Components
{
    [ViewComponent(Name = "GenreMenu")]
    public class GenreMenuComponent : ViewComponent
    {
        public GenreMenuComponent(IMusicStoreRepo repo)
        {
            this._repo = repo;
        }

        private IMusicStoreRepo _repo { get; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // TODO use nested sum https://github.com/aspnet/EntityFramework/issues/3792
            //.OrderByDescending(
            //    g => g.Albums.Sum(a => a.OrderDetails.Sum(od => od.Quantity)))
            
            var genres = await Task.Factory.StartNew( () => _repo.GetAllGenreByName(9));

            return View(genres);
        }
    }
}