using MvcSiteMapProvider;
using SklepInternetowy.DAL;
using SklepInternetowy.Models;
using System.Collections.Generic;

namespace SklepInternetowy.Infrastructure
{
    public class AlbumySzczegolyDynamicNodeProvider : DynamicNodeProviderBase
    {
        private AlbumyContext db = new AlbumyContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();
            foreach(Album album in db.Albumy)
            {
                DynamicNode node = new DynamicNode();
                node.Title = album.TytulAlbumu;
                node.Key = "Album_" + album.AlbumId;
                node.ParentKey = "Kategoria_" + album.KategoriaId;
                node.RouteValues.Add("id", album.AlbumId);
                returnValue.Add(node);
            }
            return returnValue;
        }
    }
}