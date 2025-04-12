using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IProductGroup
    {
        bool CreateProductGroup(ProductGroup productGroup);
        bool UpdateProductGroup(ProductGroup productGroup);
        bool DeleteProductGroup(int id);
        IEnumerable<ProductGroup> GetAllProductGroups();
        ProductGroup GetProductGroupById(int id);
    }
}
