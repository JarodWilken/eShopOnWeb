using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class CatalogColors : BaseEntity, IAggregateRoot
    {
        public string Colors { get; private set; }
        public CatalogColors(string colors)
        {
            Colors = colors;
        }
    }
}
