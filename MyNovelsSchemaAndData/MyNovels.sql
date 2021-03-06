
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
