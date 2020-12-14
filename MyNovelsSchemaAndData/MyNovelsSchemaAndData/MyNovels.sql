USE [MyNovels]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/14/2020 8:58:23 AM ******/
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
/****** Object:  Table [dbo].[Author]    Script Date: 12/14/2020 8:58:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Bio] [nvarchar](max) NULL,
	[NovelId] [int] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 12/14/2020 8:58:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreId] [int] IDENTITY(1,1) NOT NULL,
	[GenreOfNovel] [nvarchar](max) NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Novel]    Script Date: 12/14/2020 8:58:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Novel](
	[NovelId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Review] [datetime2](7) NOT NULL,
	[IsFamous] [bit] NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[GenreId] [int] NOT NULL,
 CONSTRAINT [PK_Novel] PRIMARY KEY CLUSTERED 
(
	[NovelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NovelAuthor]    Script Date: 12/14/2020 8:58:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NovelAuthor](
	[NovelAuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[NovelId] [int] NOT NULL,
 CONSTRAINT [PK_NovelAuthor] PRIMARY KEY CLUSTERED 
(
	[NovelAuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201203055025_startup', N'3.1.10')
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (1, N'Richard', N'Action Writer of 20''s. A great writer to read', NULL)
INSERT [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (2, N'Thomson', N'Adventure Writer of 20''s. A great writer to read', NULL)
INSERT [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (3, N'Emily', N'ROMANTIC Writer of 20''s. A great writer to read', NULL)
INSERT [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (4, N'Lilly', N'A great female writer to read', NULL)
INSERT [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (5, N'Steven Ikeme', N'“Brilliant, distinctive, thought-provoking and illuminating of a sense of place and time. Also quite readable.” Ryan', NULL)
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (1, N'Adventure')
INSERT [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (2, N'Action')
INSERT [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (3, N'Romance')
INSERT [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (4, N'Horror')
INSERT [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (5, N'Thriller')
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
SET IDENTITY_INSERT [dbo].[Novel] ON 

INSERT [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (1, N'Things Fall Apart', CAST(N'2020-05-05T00:00:00.0000000' AS DateTime2), 1, N'It’s an excellent example of black African writing in English of which I felt your list was sadly lacking. Black African novelists are often sorely under represented in literary criticism and lists of this kind. In Things Fall Apart, Achebe explores the colonial experience by arguably using the tools of colonialism itself, ie the English language. The story is told from the African perspective and his use of African colloquialisms and proverbs is genuinely subversive and innovative', 1)
INSERT [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (2, N' Robinson Crusoe', CAST(N'2019-02-02T00:00:00.0000000' AS DateTime2), 1, N'By the end of the 19th century, no book in English literary history had enjoyed more editions, spin-offs and translations. Crusoe’s world-famous novel is a complex literary confection, and it’s irresistible.', 1)
INSERT [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (3, N' Nightmare Abbey ', CAST(N'2018-02-02T00:00:00.0000000' AS DateTime2), 1, N'The great pleasure of Nightmare Abbey, which was inspired by Thomas Love Peacock’s friendship with Shelley, lies in the delight the author takes in poking fun at the romantic movement.', 4)
INSERT [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (4, N'Sybil', CAST(N'2017-01-10T00:00:00.0000000' AS DateTime2), 1, N'The future prime minister displayed flashes of brilliance that equalled the greatest Victorian novelists.', 3)
INSERT [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (5, N'The Scarlet Letter ', CAST(N'2015-10-10T00:00:00.0000000' AS DateTime2), 1, N'Nathaniel Hawthorne’s astounding book is full of intense symbolism and as haunting as anything by Edgar Allan Poe.', 2)
SET IDENTITY_INSERT [dbo].[Novel] OFF
GO
SET IDENTITY_INSERT [dbo].[NovelAuthor] ON 

INSERT [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId]) VALUES (1, 1, 1)
INSERT [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId]) VALUES (2, 2, 2)
INSERT [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId]) VALUES (3, 3, 5)
INSERT [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId]) VALUES (4, 4, 3)
INSERT [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId]) VALUES (5, 4, 4)
SET IDENTITY_INSERT [dbo].[NovelAuthor] OFF
GO
ALTER TABLE [dbo].[Author]  WITH CHECK ADD  CONSTRAINT [FK_Author_Novel_NovelId] FOREIGN KEY([NovelId])
REFERENCES [dbo].[Novel] ([NovelId])
GO
ALTER TABLE [dbo].[Author] CHECK CONSTRAINT [FK_Author_Novel_NovelId]
GO
ALTER TABLE [dbo].[Novel]  WITH CHECK ADD  CONSTRAINT [FK_Novel_Genre_GenreId] FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genre] ([GenreId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Novel] CHECK CONSTRAINT [FK_Novel_Genre_GenreId]
GO
ALTER TABLE [dbo].[NovelAuthor]  WITH CHECK ADD  CONSTRAINT [FK_NovelAuthor_Author_AuthorId] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NovelAuthor] CHECK CONSTRAINT [FK_NovelAuthor_Author_AuthorId]
GO
ALTER TABLE [dbo].[NovelAuthor]  WITH CHECK ADD  CONSTRAINT [FK_NovelAuthor_Novel_NovelId] FOREIGN KEY([NovelId])
REFERENCES [dbo].[Novel] ([NovelId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NovelAuthor] CHECK CONSTRAINT [FK_NovelAuthor_Novel_NovelId]
GO
