using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XXWindow.ViewModel
{
    public class ProductVM
    {
        public int Total { get; set; }

        public List<ProductPageModel> Products { get; set; }
    }


    public class ProductPageModel
    {

        public string ImgSrc { get; set; }
    }
}
