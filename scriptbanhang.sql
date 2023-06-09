USE [DBBanHang]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/20/2023 8:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/20/2023 8:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ParrentId] [int] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/20/2023 8:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230520072155_create-db', N'5.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230520075447_create-db1', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (1, N'Giày', 0)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (2, N'Áo', 0)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (3, N'Điện thoại', 0)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (5, N'Iphone', 3)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (6, N'Sam Sung', 3)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (7, N'Oppo', 3)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (8, N'Xiaomi', 3)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (9, N'Hunter', 1)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (10, N'Vans', 1)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (11, N'Converser', 1)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (12, N'Adidas', 1)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (13, N'Icondeim', 2)
INSERT [dbo].[Categories] ([CategoryId], [Name], [ParrentId]) VALUES (14, N'Salem', 2)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (1, N'Giày adidas Ultraboot 5.0', N'Giày Adidas Hoops 2.0 Cloud White -Màu sắc trẻ trung được ưa chuộng như item không thể thiếu cho thời trang dạo phố của bạn - Hãy ghé Minhshop để có cơ hội trải nghiệm cũng như nhận được những mức giá ưu đãi nhé.', N'https://assets.adidas.com/images/w_600,f_auto,q_auto/fd7424d087c64c038704ac84012e06a5_9366/Giay_Ultraboost_5.0_DNA_trang_GW5125_01_standard.jpg', 5000000, 10, 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (2, N'Giày adidas Ultraboot 4.0', N'Giày Adidas Hoops 2.0 Cloud White -Màu sắc trẻ trung được ưa chuộng như item không thể thiếu cho thời trang dạo phố của bạn - Hãy ghé Minhshop để có cơ hội trải nghiệm cũng như nhận được những mức giá ưu đãi nhé.', N'https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/b56f062b132c400ab494ac67011578a5_9366/Giay_Ultraboost_4.0_DNA_trang_FY9120_01_standard.jpg', 3300000, 10, 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (3, N'Giày adidas Ultraboot 1.0', N'Giày Adidas Hoops 2.0 Cloud White -Màu sắc trẻ trung được ưa chuộng như item không thể thiếu cho thời trang dạo phố của bạn - Hãy ghé Minhshop để có cơ hội trải nghiệm cũng như nhận được những mức giá ưu đãi nhé.', N'https://assets.adidas.com/images/w_600,f_auto,q_auto/9357081632b842d5b5e1ac8c0104afcc_9366/Giay_Ultraboost_1.0_DNA_Mau_vang_FX7977_01_standard.jpg', 4000000, 7, 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (4, N'Giày adidas Ultraboot 2.0', N'Giày Adidas Hoops 2.0 Cloud White -Màu sắc trẻ trung được ưa chuộng như item không thể thiếu cho thời trang dạo phố của bạn - Hãy ghé Minhshop để có cơ hội trải nghiệm cũng như nhận được những mức giá ưu đãi nhé.', N'https://assets.adidas.com/images/w_600,f_auto,q_auto/4ad856ac0f4b4809a13cad1000bc09a9_9366/Giay_Response_Super_2.0_DJen_G58068_01_standard.jpg', 3800000, 8, 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (5, N'Giày adidas basic', N'Giày Adidas Hoops 2.0 Cloud White -Màu sắc trẻ trung được ưa chuộng như item không thể thiếu cho thời trang dạo phố của bạn - Hãy ghé Minhshop để có cơ hội trải nghiệm cũng như nhận được những mức giá ưu đãi nhé.', N'https://assets.adidas.com/images/w_600,f_auto,q_auto/1fe05516b2f44b98ab1fae7b01374f56_9366/Giay_Response_Super_3.0_trang_GW1379_01_standard.jpg', 2900000, 9, 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (6, N'Giày adidas chạy bộ', N'Giày Adidas Hoops 2.0 Cloud White -Màu sắc trẻ trung được ưa chuộng như item không thể thiếu cho thời trang dạo phố của bạn - Hãy ghé Minhshop để có cơ hội trải nghiệm cũng như nhận được những mức giá ưu đãi nhé.', N'https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/b56f062b132c400ab494ac67011578a5_9366/Giay_Ultraboost_4.0_DNA_trang_FY9120_01_standard.jpg', 1500000, 10, 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (8, N'Điện thoại iphone 14 Pro Max 128Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://cdn.tgdd.vn/Products/Images/42/251192/iphone-14-pro-max-den-thumb-600x600.jpg', 28999000, 20, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (9, N'Điện thoại iphone 14 Pro 128Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://shopdunk.com/images/thumbs/0007808_iphone-14-pro-max-128gb.png', 25000000, 25, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (10, N'Điện thoại iphone 14', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://vn-live.slatic.net/p/26c2a39938b1659b0247d3135dac138e.jpg', 20000000, 20, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (11, N'Điện thoại iphone 13 Pro Max 516Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://cdn.tgdd.vn/Products/Images/42/230529/iphone-13-pro-max-xanh-la-thumb-600x600.jpg', 23000000, 20, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (12, N'Điện thoại iphone 13 Pro 128Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://smartviets.com/template/plugins/timthumb.php?src=/upload/image/slide/13/13%20pro%20tr%E1%BA%AFng.jpg&w=770&h=770&q=80', 19000000, 5, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (13, N'Điện thoại iphone 12 Pro 256Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://cdn.tgdd.vn/Products/Images/42/213032/iphone-12-pro-xam-new-600x600-2-600x600.jpg', 16000000, 5, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (14, N'Điện thoại iphone 12 mini 128Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://cdn.tgdd.vn/Products/Images/42/251192/iphone-14-pro-max-den-thumb-600x600.jpg', 14000000, 15, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (15, N'Điện thoại iphone x 128Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://cdn.tgdd.vn/Products/Images/42/225380/iphone-12-mini-mau-tim-3-600x600.jpg', 10000000, 35, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (16, N'Điện thoại iphone 11 256Gb', N'Cụ thể, iPhone 14 thường vẫn được trang bị màn hình Super Retina XDR OLED với kích thước 6.1 inch. Đây vẫn là kiểu màn hình tai thỏ quen thuộc. Độ phân giải 1170 x 2532 pixels, mật độ điểm ảnh 460 ppi, tần số quét 60Hz, gần như các thông số, tính năng vẫn được giữ nguyên.', N'https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-200x200.jpg', 8000000, 10, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (18, N'Áo sơ mi IconDeim ', N'Đep', N'https://dosi-in.com/images/detailed/380/dosiin-icon-denim-ao-somi-tay-ngan-icon-denim-typo-pattern-380638380638.jpg', 250000, 5, 13)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (19, N'Áo thun IconDeim ', N'Đep', N'https://product.hstatic.net/1000360022/product/untitled-2_f240f0f8cb204b25a949030393aff9cf.jpg', 250000, 5, 13)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (20, N'Áo khoác IconDeim ', N'Đep', N'https://dosi-in.com/images/detailed/526/dosiin-icon-denim-ao-khoac-varsity-icondenim-526901526901.jpg', 600000, 5, 13)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (21, N'Áo gió IconDeim ', N'Đep', N'https://product.hstatic.net/1000360022/product/untitled-1_6f1c248df860433a9e5daa5d2b383dc9.jpg', 450000, 5, 13)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (23, N'Điện thoại Samsung Galaxy A73 5G 128GB', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn.tgdd.vn/Products/Images/42/246195/samsung-galaxy-a73-5g-xanh-thumb-600x600.jpg', 8000000, 0, 6)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (24, N'Điện thoại Samsung Galaxy S23 5G 128GB', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn.tgdd.vn/Products/Images/42/264060/samsung-galaxy-s23-600x600.jpg', 12000000, 10, 6)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (25, N'Samsung Galaxy Z Flip4 5G 128GB Chính Hãng', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn-v2.didongviet.vn/files/media/catalog/product/s/a/samsung-galaxy-z-flip4-5g-128gb-didongviet_1_1.jpg', 20000000, 0, 6)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (26, N'Điện thoại Xiaomi Redmi Note 11 Pro (5G) đã kích hoạt | Giá giảm sốc', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn2.cellphones.com.vn/x358,webp,q100/media/catalog/product/t/_/t_i_xu_ng_2_18_2.png', 10000000, 20, 8)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (27, N'Điện thoại Xiaomi (Redmi - Mi) Giá rẻ - Bảng giá mới nhất 2023', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn2.cellphones.com.vn/358x358,webp,q100/media/catalog/product/1/1/11-pro-plus-blue.jpg', 12000000, 10, 8)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (28, N'Điện thoại Xiaomi Redmi Note 12 Pro (Dimensity 1080) - Hàng nhập khẩu tại Barley Star Coffee', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cf.shopee.vn/file/sg-11134201-22110-bzmdxxlxxojve7', 20000000, 0, 8)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (29, N'Mua điện thoại OPPO chính hãng giá tốt | Trả góp 0% - ViettelStore.vn', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn1.viettelstore.vn/images/Product/ProductImage/medium/OPPO-A17-ble1.jpg', 10000000, 20, 7)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (30, N'OPPO A95 | Pin khủng, sạc nhanh, giá tốt nhất', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://images.fpt.shop/unsafe/fit-in/585x390/filters:quality(5):fill(white)/fptshop.com.vn/Uploads/Originals/2021/11/20/637730059696400830_oppo-a95-bac-1.jpg', 12000000, 10, 7)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (31, N'Điện thoại smartphone OPPO chính hãng, giá rẻ', N'Mở ra tương lai cùng Samsung Galaxy Z Flip4 128GB. Hàng chính hãng, giá chỉ từ 13tr49, tradein giá tốt nhất, góp 0%/24 tháng, bảo hành 12 tháng', N'https://cdn.tgdd.vn/Products/Images/42/249944/oppo-a55-4g-thumb-new-600x600.jpg', 20000000, 0, 7)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (32, N'Giày Thể Thao Nam Biti''s Hunter Core Festive 3D - Liteknit Grey DSMH07800XAM (Xám)', N'Đẹp', N'https://product.hstatic.net/1000230642/product/dsmh07800xam__3__d632619868fb42b0828a032155c205c9.jpg', 900000, 0, 9)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (33, N'Giày Thể Thao Cao Cấp Nữ Biti''s Hunter Core Classic Pink DSWH05000DEN', N'Đẹp', N'https://product.hstatic.net/1000230642/product/dswh0500den-1_56288af60fca4015bbe779cb23a49566.jpg', 600000, 0, 9)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (34, N'Giày Thể Thao Nam Biti''s Hunter Core Refreshing Collection Contras Black DSMH06700DEN (Đen)', N'Đẹp', N'https://product.hstatic.net/1000230642/product/dswh0500den-1_56288af60fca4015bbe779cb23a49566.jpg', 700000, 0, 9)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (36, N'Giày Vans Old Skool Đen Nam Nữ [ẢNH THẬT + SALE SỐC] | Lazada.vn', N'Đẹp', N'https://vn-test-11.slatic.net/p/7e888604124698a20fa433426757de3e.jpg', 2000000, 10, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (37, N'Giày Vans trắng đẹp đến nao lòng WearVN', N'Đẹp', N'https://bizweb.dktcdn.net/100/347/923/files/giay-vans-trang-3.jpg?v=1581644220663', 2000000, 10, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (38, N'Giày Converse Chuck Taylor All Star Move Hi Top', N'Đẹp', N'https://bizweb.dktcdn.net/100/347/923/products/568497c-6.jpg?v=1597673112317', 2000000, 10, 11)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Image], [Price], [Discount], [CategoryId]) VALUES (39, N'Giày Converse Chính Hãng Loang 3 Màu Cổ Thấp – 2TStore', N'Đẹp', N'https://product.hstatic.net/1000392227/product/loang_3_mau_trong_97e00f34e83b4cfe82ed6d6c00a07544_master.jpg', 2000000, 10, 11)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Categories] ADD  DEFAULT ((0)) FOR [ParrentId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
