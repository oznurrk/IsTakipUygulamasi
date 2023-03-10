USE [BIMSER]
GO
/****** Object:  Table [dbo].[IsTakipTanim]    Script Date: 18.12.2022 12:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsTakipTanim](
	[IsTakipTanim_rowid] [int] IDENTITY(1,1) NOT NULL,
	[sTicketNumarasi] [nvarchar](50) NOT NULL,
	[pMusteri] [int] NOT NULL,
	[sKonu] [nvarchar](50) NOT NULL,
	[sAciklama] [nvarchar](50) NOT NULL,
	[sUstAciklama] [nvarchar](50) NOT NULL,
	[pSorumlu] [int] NOT NULL,
	[dtPlanlamaTarihi] [datetime] NULL,
	[dtTamamlamaTarihi] [datetime] NULL,
	[sDurum] [nvarchar](5) NOT NULL,
	[bMailGonder] [bit] NOT NULL,
 CONSTRAINT [PK_IsTakipTanim] PRIMARY KEY CLUSTERED 
(
	[IsTakipTanim_rowid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriTanim]    Script Date: 18.12.2022 12:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriTanim](
	[MusteriTanim_rowid] [int] IDENTITY(1,1) NOT NULL,
	[sAdiSoyadi] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_MusteriTanim] PRIMARY KEY CLUSTERED 
(
	[MusteriTanim_rowid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SorumluTanim]    Script Date: 18.12.2022 12:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SorumluTanim](
	[SorumluTanim_rowid] [int] IDENTITY(1,1) NOT NULL,
	[sAdiSoyadi] [nvarchar](50) NOT NULL,
	[sPozisyon] [nvarchar](50) NOT NULL,
	[sMail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SorumluTanim] PRIMARY KEY CLUSTERED 
(
	[SorumluTanim_rowid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IsTakipTanim] ON 

INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (17, N'AB11111111', 1, N'Ses inceleme', N'​Konuşmacı Teşhis ve Tanıma', N'Kayıt İyileştirme', 1, CAST(N'2022-12-17T00:00:00.000' AS DateTime), CAST(N'2022-12-18T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (18, N'AB11111112', 2, N'Konuşmacı Profili Belirleme', N'kayıtlı fotoğraflardan kişi tespiti', N'Görüntülerin incelenmesi', 2, CAST(N'2022-12-18T00:00:00.000' AS DateTime), CAST(N'2022-12-20T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (19, N'AB11111113', 3, N'Sinyal Çözümlemesi', N'GPS', N'Sinyal Çözümlemesi', 3, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (20, N'AB11111114', 4, N'Görüntü Karşılaştırma', N'Montaj ve Kurgu İncelemeleri', N'DATA İNCELEME
', 1, CAST(N'2022-12-22T00:00:00.000' AS DateTime), CAST(N'2022-12-24T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (21, N'AB11111115', 5, N'call_record UPDATE', N'Çağrıları dinleyebilmeniz için call_record kısmı', N'Error', 2, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (22, N'AB11111116', 6, N'Tahsilat aramaları', N'Günlük tahsilat listesi', N'ACİL', 3, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (23, N'AB11111117', 7, N'Randevu aramaları 2', N'Randevuların listelenmemesi', N'haftalık randevu listeleme', 1, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (24, N'AB11111118', 8, N'Anket sonuç görüntüleme', N'Verilerin yüklenmemesi', N'Error', 2, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (25, N'AB11111119', 9, N'IVR (Sesli Yanıt Sistemi)', N'Kayıtların açılmaması', N'yükleme hatası', 3, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (26, N'AB11111120', 10, N'Ürün / Hizmet bilgisi', N'ürün ve hizmetlerin listelenmesi', N'Listeleme sorunu', 1, CAST(N'2022-12-20T00:00:00.000' AS DateTime), CAST(N'2022-12-22T00:00:00.000' AS DateTime), N'Aktif', 0)
INSERT [dbo].[IsTakipTanim] ([IsTakipTanim_rowid], [sTicketNumarasi], [pMusteri], [sKonu], [sAciklama], [sUstAciklama], [pSorumlu], [dtPlanlamaTarihi], [dtTamamlamaTarihi], [sDurum], [bMailGonder]) VALUES (27, N'AB11111121', 3, N'Grid Üzerinden veri eklenmesi', N'Veri ekleme', N'Gridview', 2, CAST(N'2022-12-17T00:00:00.000' AS DateTime), CAST(N'2022-12-17T00:00:00.000' AS DateTime), N'Pasif', 0)
SET IDENTITY_INSERT [dbo].[IsTakipTanim] OFF
GO
SET IDENTITY_INSERT [dbo].[MusteriTanim] ON 

INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (1, N'Hasan SAK')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (2, N'Eyüphan SAĞLAM')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (3, N'Ömer KOCACIK')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (4, N'Coşkun KÜÇÜK')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (5, N'Aylin KARA')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (6, N'Ramazan CAN')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (7, N'Hilal BEKAR')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (8, N'Mehmet GÜRBÜZ')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (9, N'Gökhan DÖNMEZ')
INSERT [dbo].[MusteriTanim] ([MusteriTanim_rowid], [sAdiSoyadi]) VALUES (10, N'Soner KAHYA')
SET IDENTITY_INSERT [dbo].[MusteriTanim] OFF
GO
SET IDENTITY_INSERT [dbo].[SorumluTanim] ON 

INSERT [dbo].[SorumluTanim] ([SorumluTanim_rowid], [sAdiSoyadi], [sPozisyon], [sMail]) VALUES (1, N'Öznur SAK', N'Yazılım Mühendisi', N'oznurkocacik@gmail.com')
INSERT [dbo].[SorumluTanim] ([SorumluTanim_rowid], [sAdiSoyadi], [sPozisyon], [sMail]) VALUES (2, N'Betül KALFA', N'Yazılım Mühendisi', N'betul.kalfa@gmail.com')
INSERT [dbo].[SorumluTanim] ([SorumluTanim_rowid], [sAdiSoyadi], [sPozisyon], [sMail]) VALUES (3, N'Ercan GÜL', N'Android Geliştiricisi', N'ercan.gul@gmail.com')
SET IDENTITY_INSERT [dbo].[SorumluTanim] OFF
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_IsTakipTanim_sTicketNumarasi]  DEFAULT ('') FOR [sTicketNumarasi]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_IsTakipTanim_pMusteri]  DEFAULT ((0)) FOR [pMusteri]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_IsTakipTanim_sKonu]  DEFAULT ('') FOR [sKonu]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_Table_1_sKonu1]  DEFAULT ('') FOR [sAciklama]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_Table_1_sKonu2]  DEFAULT ('') FOR [sUstAciklama]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_Table_1_pMusteri1]  DEFAULT ((0)) FOR [pSorumlu]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_IsTakipTanim_sDurum]  DEFAULT ('') FOR [sDurum]
GO
ALTER TABLE [dbo].[IsTakipTanim] ADD  CONSTRAINT [DF_IsTakipTanim_bMailGonder]  DEFAULT ((0)) FOR [bMailGonder]
GO
ALTER TABLE [dbo].[MusteriTanim] ADD  CONSTRAINT [DF_MusteriTanim_sAdiSoyadi]  DEFAULT ('') FOR [sAdiSoyadi]
GO
ALTER TABLE [dbo].[SorumluTanim] ADD  CONSTRAINT [DF_SorumluTanim_sAdiSoyadi]  DEFAULT ('') FOR [sAdiSoyadi]
GO
ALTER TABLE [dbo].[SorumluTanim] ADD  CONSTRAINT [DF_SorumluTanim_sPozisyon]  DEFAULT ('') FOR [sPozisyon]
GO
ALTER TABLE [dbo].[SorumluTanim] ADD  CONSTRAINT [DF_SorumluTanim_sMail]  DEFAULT ('') FOR [sMail]
GO
ALTER TABLE [dbo].[IsTakipTanim]  WITH CHECK ADD  CONSTRAINT [FK_IsTakipTanim_MusteriTanim] FOREIGN KEY([pMusteri])
REFERENCES [dbo].[MusteriTanim] ([MusteriTanim_rowid])
GO
ALTER TABLE [dbo].[IsTakipTanim] CHECK CONSTRAINT [FK_IsTakipTanim_MusteriTanim]
GO
ALTER TABLE [dbo].[IsTakipTanim]  WITH CHECK ADD  CONSTRAINT [FK_IsTakipTanim_SorumluTanim] FOREIGN KEY([pSorumlu])
REFERENCES [dbo].[SorumluTanim] ([SorumluTanim_rowid])
GO
ALTER TABLE [dbo].[IsTakipTanim] CHECK CONSTRAINT [FK_IsTakipTanim_SorumluTanim]
GO
