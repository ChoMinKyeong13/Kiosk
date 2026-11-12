using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public static class Productstore
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ProductId = "P001", Name = "할파피뇨치즈버거", Price = 4500, Category = "버거", ImagePath = "Images/burger1.png" },
            new Product { ProductId = "P002", Name = "빅콘불고기버거", Price = 5000, Category = "버거", ImagePath = "Images/burger2.png" },
            new Product { ProductId = "P003", Name = "양념통치킨버거", Price = 4800, Category = "버거", ImagePath = "Images/burger3.png" },
            new Product { ProductId = "P004", Name = "비프에그불고기버거", Price = 5200, Category = "버거", ImagePath = "Images/burger4.png" },
            new Product { ProductId = "P005", Name = "스파이시마요새우버거", Price = 5500, Category = "버거", ImagePath = "Images/burger5.png" },
            new Product { ProductId = "P006", Name = "불닭마요통치킨버거", Price = 6500, Category = "버거", ImagePath = "Images/burger6.png" },
            new Product { ProductId = "P007", Name = "마늘간장통치킨버거", Price = 5800, Category = "버거", ImagePath = "Images/burger7.png" },
            new Product { ProductId = "P008", Name = "더블불고기치즈버거", Price = 4200, Category = "버거", ImagePath = "Images/burger8.png" },


            new Product { ProductId = "P003", Name = "스팸참치김밥", Price = 6000, Category = "라이스", ImagePath = "Images/rice1.png" },
            new Product { ProductId = "P004", Name = "전주비빔참치마요김밥", Price = 5500, Category = "라이스", ImagePath = "Images/rice2.png" },
            new Product { ProductId = "P011", Name = "마늘통한불고기김밥", Price = 6200, Category = "라이스", ImagePath = "Images/rice3.png" },
            new Product { ProductId = "P012", Name = "매콤우엉참치마요김밥", Price = 5800, Category = "라이스", ImagePath = "Images/rice4.png" },
            new Product { ProductId = "P013", Name = "김치볶음참치마요김밥", Price = 6000, Category = "라이스", ImagePath = "Images/rice5.png" },
            new Product { ProductId = "P014", Name = "떡갈비계란김밥", Price = 5500, Category = "라이스", ImagePath = "Images/rice6.png" },
            new Product { ProductId = "P015", Name = "소불고기마요듬뿍김밥", Price = 6300, Category = "라이스", ImagePath = "Images/rice7.png" },
            new Product { ProductId = "P016", Name = "통돈가스김밥", Price = 6800, Category = "라이스", ImagePath = "Images/rice8.png" },

            new Product { ProductId = "P005", Name = "맵탱마늘조개라면", Price = 1500, Category = "라면", ImagePath = "Images/ramen1.png" },
            new Product { ProductId = "P006", Name = "맴탱청양고추대파라면", Price = 1800, Category = "라면", ImagePath = "Images/ramen2.png" },
            new Product { ProductId = "P019", Name = "스낵면", Price = 1400, Category = "라면", ImagePath = "Images/ramen3.png" },
            new Product { ProductId = "P020", Name = "진비빔면", Price = 1700, Category = "라면", ImagePath = "Images/ramen4.png" },
            new Product { ProductId = "P021", Name = "참깨라면", Price = 1600, Category = "라면", ImagePath = "Images/ramen5.png" },
            new Product { ProductId = "P022", Name = "라뽁구리라면", Price = 1900, Category = "라면", ImagePath = "Images/ramen6.png" },
            new Product { ProductId = "P023", Name = "신라면로제", Price = 1600, Category = "라면", ImagePath = "Images/ramen7.png" },
            new Product { ProductId = "P024", Name = "신라면투움바", Price = 1700, Category = "라면", ImagePath = "Images/ramen8.png" },

            new Product { ProductId = "P007", Name = "라라스윗딥치즈갈릭팝콘(저당)", Price = 2000, Category = "과자", ImagePath = "Images/snack1.png" },
            new Product { ProductId = "P008", Name = "김치칩", Price = 1700, Category = "과자", ImagePath = "Images/snack2.png" },
            new Product { ProductId = "P027", Name = "버터앤솔트팝콘", Price = 2200, Category = "과자", ImagePath = "Images/snack3.png" },
            new Product { ProductId = "P028", Name = "미쯔황치즈", Price = 2000, Category = "과자", ImagePath = "Images/snack4.png" },
            new Product { ProductId = "P029", Name = "프링글스", Price = 3500, Category = "과자", ImagePath = "Images/snack5.png" },
            new Product { ProductId = "P030", Name = "오사쯔델리만쥬맛", Price = 3200, Category = "과자", ImagePath = "Images/snack6.png" },
            new Product { ProductId = "P031", Name = "죠리퐁", Price = 1500, Category = "과자", ImagePath = "Images/snack7.png" },
            new Product { ProductId = "P032", Name = "칙촉스윗콘", Price = 2500, Category = "과자", ImagePath = "Images/snack8.png" },

            new Product { ProductId = "P009", Name = "모구모구", Price = 1800, Category = "음료", ImagePath = "Images/drink1.png" },
            new Product { ProductId = "P010", Name = "코카콜라제로라임", Price = 2500, Category = "음료", ImagePath = "Images/drink2.png" },
            new Product { ProductId = "P035", Name = "펩시제로", Price = 1800, Category = "음료", ImagePath = "Images/drink3.png" },
            new Product { ProductId = "P036", Name = "밀키스", Price = 2200, Category = "음료", ImagePath = "Images/drink4.png" },
            new Product { ProductId = "P037", Name = "이온킥", Price = 1900, Category = "음료", ImagePath = "Images/drink5.png" },
            new Product { ProductId = "P038", Name = "오렌지주스", Price = 1700, Category = "음료", ImagePath = "Images/drink6.png" },
            new Product { ProductId = "P039", Name = "에너지드링크", Price = 2800, Category = "음료", ImagePath = "Images/drink7.png" },
            new Product { ProductId = "P040", Name = "망고웰치스제로", Price = 1000, Category = "음료", ImagePath = "Images/drink8.png" },
            
            new Product { ProductId = "P011", Name = "햇반아이스크림", Price = 1500, Category = "아이스크림", ImagePath = "Images/icecream1.png" },
            new Product { ProductId = "P012", Name = "나뚜루말차", Price = 1200, Category = "아이스크림", ImagePath = "Images/icecream2.png" },
            new Product { ProductId = "P043", Name = "메로나", Price = 1300, Category = "아이스크림", ImagePath = "Images/icecream3.png" },
            new Product { ProductId = "P044", Name = "비비빅", Price = 2000, Category = "아이스크림", ImagePath = "Images/icecream4.png" },
            new Product { ProductId = "P045", Name = "쿠앤크", Price = 1000, Category = "아이스크림", ImagePath = "Images/icecream5.png" },
            new Product { ProductId = "P046", Name = "빵빠레", Price = 1800, Category = "아이스크림", ImagePath = "Images/icecream6.png" },
            new Product { ProductId = "P047", Name = "돼지빵", Price = 1700, Category = "아이스크림", ImagePath = "Images/icecream7.png" },
            new Product { ProductId = "P048", Name = "하이츄바", Price = 1200, Category = "아이스크림", ImagePath = "Images/icecream8.png" },
        };

        public static List<Product> GetAllProducts()
        {
            return products;
        }

        public static List<Product> GetByCategory(string category)
        {
            return products.Where(p => p.Category == category).ToList();
        }
    }
}
