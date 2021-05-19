using FreshGroci1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.Data
{
    public class ProductData
    {
        public List<ProductModel> GetAllProduct()
        {
            return DataSource();
        }
        public ProductModel GetProductById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        private List<ProductModel> DataSource()
        {
            return new List<ProductModel>()
            {
                new ProductModel(){Id = 1, 
                    Name = "Almonds", 
                    Image = "https://vfresh.oremda.com/wp-content/uploads/2021/05/Almd.jpg",
                    ShortDescription = "Almonds are rich in nutrients, especially magnesium, which help curb down hypertension and maintain good heart health.",
                    Description = "Almonds are rich in nutrients, especially magnesium, which help curb down hypertension and maintain good heart health. Helps in weight loss the mono unsaturated fat found in almonds prevents over eating and the dietary fiber makes you feel full, despite eating a small amount. Great for skin massaging your skin with almond oil makes it smooth and also adds a healthy glow, it can also improve your complexion. Packed in an integrated nuts and dried fruits unit and may contain occasional traces of other nuts and dried fruits. Agricultural produce of united states.", 
                    price = "600.00", 
                    Category = "Dry Fruits"},

                new ProductModel(){Id = 2, 
                    Name = "Raisins", 
                    Image = "https://vfresh.oremda.com/wp-content/uploads/2020/11/Kishmish-1-scaled.jpg",
                    ShortDescription = "It gains a healthy weight.", 
                    Description = "It gains a healthy weight It contributes to improved blood glucose control in diabetic It helps to lower fevers by fighting infections and enhances mouth health Rich source of energy and contains antioxidants", 
                    price = "600.00", 
                    Category = "Dry Fruits"},

                 new ProductModel(){Id = 3,
                    Name = "Apple Regular",
                    Image = "https://vfresh.oremda.com/wp-content/uploads/2020/11/apple-fruit-500x500-2.jpg",
                    ShortDescription = "Apples are one of the healthiest fruits. Rich in vitamin C and dietary fiber.",
                    Description = "Apples are one of the healthiest fruits. Rich in vitamin C and dietary fiber which keep our digestive and immune system healthy. Protects from Alzheimers, type 2 diabetes and cancer. It’s a natural teeth whitener and prevent bad breath. Eating apple peel lowers the risk of obesity. Apple mask is an excellent cure for wrinkles.",
                    price = "160.00",
                    Category = "Fruits"},

                  new ProductModel(){Id = 4,
                    Name = "Black Currant",
                    Image = "https://vfresh.oremda.com/wp-content/uploads/2020/11/purepng.com-black-currantfruitsberryberriesblack-currantcurrants-98152518546807l4p.png",
                    ShortDescription = "Black Currants carry four times the amount of vitamin C as oranges, and double the amount of antioxidants as blueberries. The benefits of vitamin C are many. The body uses vitamin C to metabolize protein and form collagen, which is essential for skin care and anti-aging..",
                    Description = "About the Product Black Currant – Black Currants carry four times the amount of vitamin C as oranges, and double the amount of antioxidants as blueberries. The benefits of vitamin C are many. The body uses vitamin C to metabolize protein and form collagen, which is essential for skin care and anti - aging. Benefits High cholesterol.Some research suggests that taking black currant seed oil can reduce total cholesterol and blood fats called triglycerides.It also seems to increase good high - density lipoprotein(HDL)",
                    price = "110.00",
                    Category = "Fruits"},

                   new ProductModel(){Id = 5,
                    Name = "Blueberry",
                    Image = "https://vfresh.oremda.com/wp-content/uploads/2020/11/unnamed-3.png",
                    ShortDescription = "Sweet with a deep taste and a sticky chewy texture, these dried prunes.",
                    Description = "Sweet with a deep taste and a sticky chewy texture, these dried prunes are not only fun to eat but they are also highly nutritious. Ideal for cooking and snacking. This healthy snack is naturally fat-free and high in potassium and fibre. It contains no added sugar or preservatives. It is fibre rich and aids weight loss. It is a very healthy snack.",
                    price = "261.00",
                    Category = "Fruits"},

                    new ProductModel(){Id = 6,
                    Name = "Watermelon ",
                    Image = "https://vfresh.oremda.com/wp-content/uploads/2020/11/slice-watermelon-white-background_93675-75145.jpg",
                    ShortDescription = "It gains a healthy weight.",
                    Description = "It gains a healthy weight It contributes to improved blood glucose control in diabetic It helps to lower fevers by fighting infections and enhances mouth health Rich source of energy and contains antioxidants",
                    price = "600.00",
                    Category = "Dry Fruits"},
                };
        }
    }
}
