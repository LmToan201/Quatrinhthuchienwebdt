using QuanLyBanDienThoai.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanDienThoai.Models
{
    public class SeedData
    {
		public static void Initialize(ApplicationDbContext context)
		{
			context.Database.EnsureCreated();

			// Look for any data
			if (context.Product.Any())
			{
				return;   // DB has been seeded
			}

			var products = new Product[]
			{
				new Product{Name="Điện thoại Samsung Galaxy Z Flip4 128GB",Manufacturer="Samsung",Price=20990000,Quantity=50,Desciption="Samsung Galaxy Z Flip4 128GB đã chính thức ra mắt thị trường công nghệ.",Image="a1SS.jpg"},
				new Product{Name="Điện thoại iPhone 11 thường 64GB",Manufacturer="Apple",Price=11690000,Quantity=170,Desciption="Apple đã chính thức trình làng bộ 3 siêu phẩm iPhone 11.",Image="a2iphone11.jpg"},
				new Product{Name="Điện thoại Xiaomi Redmi Note 11 (4GB/64GB)",Manufacturer="Xiaomi",Price=4490000,Quantity=70,Desciption="Điện thoại Redmi được mệnh danh là dòng sản phẩm quốc dân ngon-bổ-rẻ của Xiaomi và Redmi Note 11 (4GB/64GB). ",Image="a3Xiaominote11.jpg"},
				new Product{Name="Điện thoại Samsung Galaxy S22 Ultra 5G 128GB",Manufacturer="Samsung",Price=27990000,Quantity=55,Desciption="Galaxy S22 Ultra 5G chiếc smartphone cao cấp nhất trong bộ 3 Galaxy S22 series mà Samsung đã cho ra mắt.",Image="a4GalaxyS22Ultra.jpg"},
				new Product{Name="Điện thoại Xiaomi Redmi Note 11S 5G",Manufacturer="Xiaomi",Price=6090000,Quantity=200,Desciption="Tại sự kiện ra mắt sản phẩm mới diễn ra hôm 29/3, điện thoại Xiaomi đã ra mắt Redmi Note 11S 5G toàn cầu.",Image="a5xiaomiredminote11s.jpg"},
				new Product{Name="Điện thoại iPhone 13 Pro Max 256GB",Manufacturer="Apple",Price=30490000,Quantity=250,Desciption="iPhone 13 Pro Max 256GB - siêu phẩm mang trên mình bộ vi xử lý Apple A15 Bionic hàng đầu.",Image="a6iphone13promax.jpg"},
				new Product{Name="Điện thoại Samsung Galaxy A23 4GB",Manufacturer="Samsung",Price=5690000,Quantity=300,Desciption="Samsung Galaxy A23 4GB sở hữu bộ thông số kỹ thuật khá ấn tượng trong phân khúc.",Image="a7samsunggalaxya23.jpg"},
				new Product{Name="Điện thoại Vivo Y15s Camera Full HD",Manufacturer="Vivo",Price=3090000,Quantity=320,Desciption="Vivo vừa mang một chiến binh mới đến phân khúc tầm trung giá rẻ có tên Vivo Y15s.",Image="a8Vivoy15s.jpg"},
				new Product{Name="Điện thoại OPPO Reno8 Pro 5G Camera HD",Manufacturer="OPPO",Price=18900000,Quantity=123,Desciption="OPPO Reno8 Pro 5G là chiếc điện thoại cao cấp được nhà OPPO ra mắt vào thời điểm 09/2022.",Image="a9opporeno8pro.jpg"},
				new Product{Name="Điện thoại OPPO A55 phiên bản màu xanh ",Manufacturer="OPPO",Price=4490000,Quantity=120,Desciption="OPPO cho ra mắt OPPO A55 4G chiếc smartphone giá rẻ tầm trung có thiết kế đẹp mắt, cấu hình khá ổn.",Image="a10oppoa554g.jpg"},
				new Product{Name="Điện thoại iPhone 14 Pro Max 128GB ",Manufacturer="Apple",Price=33590000,Quantity=340,Desciption="Cuối cùng thì chiếc iPhone 14 Pro Max cũng đã chính thức lộ diện tại sự kiện ra mắt thường niên vào ngày 08/09 đến từ nhà Apple.",Image="a11iphone-14promax.jpg"},
				new Product{Name="Điện thoại iPhone 14 Pro tím 128GB  ",Manufacturer="Apple",Price=3059000,Quantity=400,Desciption="Tại sự kiện ra mắt sản phẩm thường niên diễn ra vào tháng 9/2022, Apple đã trình làng iPhone 14 Pro.",Image="a13iphone14protim.jpg"},
				new Product{Name="Điện thoại iPhone 13 Pro 512GB Camera HD",Manufacturer="Apple",Price=28990000,Quantity=150,Desciption="iPhone 13 Pro 512GB - chiếc điện thoại nằm trong iPhone 13 Series của Apple, mang những cải tiến ấn tượng từ trong cấu hình.",Image="a14iphone13pro.jpg"},
				new Product{Name="Điện thoại Samsung Galaxy Z Fold3 5G 256GB ",Manufacturer="Samsung",Price=27990000,Quantity=320,Desciption="Samsung Galaxy Z Fold3 5G, chiếc điện thoại được nâng cấp toàn diện về nhiều mặt.",Image="a15samsunggalaxy.jpg"}
			};

			context.Product.AddRange(products);
			context.SaveChanges();
		}
	}
}
