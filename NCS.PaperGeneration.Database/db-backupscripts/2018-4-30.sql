USE [NC-DB]
GO
/****** Object:  Table [dbo].[Algorithms]    Script Date: 5/1/2018 12:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Algorithms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedById] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedById] [int] NULL,
 CONSTRAINT [PK_dbo.Algorithms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chapter]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chapter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChapterName] [nvarchar](max) NOT NULL,
	[ChapterDescription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.Chapter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Choice]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Choice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[ChoiceString] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
	[IsJumble] [bit] NOT NULL,
	[CorrentOrWrong] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.Choice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlgorithmId] [int] NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Description] [nvarchar](1000) NULL,
	[TotalQuestions] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.Exam] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamChapter]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamChapter](
	[ExamId] [int] NOT NULL,
	[ChapterId] [int] NOT NULL,
	[NumberOfQuestionsFromChapter] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.ExamChapter] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC,
	[ChapterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[Url] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.Image] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[LoginUserName] [nvarchar](max) NULL,
	[PhoneNumber] [int] NOT NULL,
	[Nic] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.LoginUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SectionId] [int] NOT NULL,
	[QuestionContent] [nvarchar](max) NULL,
	[Explantion] [nvarchar](max) NULL,
	[NumberOfChoices] [int] NOT NULL,
	[Priority] [int] NOT NULL,
	[CanRandomizeChoices] [bit] NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[Tag] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavedPapers]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavedPapers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.SavedPapers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SectionName] [nvarchar](max) NULL,
	[ChapterId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.Sections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserExamAttempt]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserExamAttempt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NOT NULL,
	[LoginUserId] [int] NOT NULL,
	[Attempt] [int] NOT NULL,
	[Marks] [int] NULL,
	[PassofFail] [bit] NULL,
	[ExamDate] [datetime] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_dbo.UserExamAttempt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserExamAttemptQuestion]    Script Date: 5/1/2018 12:09:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserExamAttemptQuestion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserExamId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
	[ChoiceId] [int] NULL,
	[IsAnswered] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_UserExamAttemptQuestion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Algorithms] ON 

INSERT [dbo].[Algorithms] ([Id], [Name], [Description], [CreatedDate], [CreatedById], [UpdatedDate], [UpdatedById]) VALUES (1, N'default', N'default', CAST(N'2018-03-16T16:58:26.823' AS DateTime), 1, CAST(N'2018-03-16T16:58:26.823' AS DateTime), 1)
INSERT [dbo].[Algorithms] ([Id], [Name], [Description], [CreatedDate], [CreatedById], [UpdatedDate], [UpdatedById]) VALUES (3, N'first', N'first', CAST(N'2018-04-20T00:00:00.000' AS DateTime), 1, CAST(N'2018-04-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Algorithms] ([Id], [Name], [Description], [CreatedDate], [CreatedById], [UpdatedDate], [UpdatedById]) VALUES (4, N'second', N'second', CAST(N'2018-04-20T00:00:00.000' AS DateTime), 1, CAST(N'2018-04-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Algorithms] ([Id], [Name], [Description], [CreatedDate], [CreatedById], [UpdatedDate], [UpdatedById]) VALUES (5, N'thired', N'thired', CAST(N'2018-04-20T00:00:00.000' AS DateTime), 1, CAST(N'2018-04-20T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Algorithms] OFF
SET IDENTITY_INSERT [dbo].[Chapter] ON 

INSERT [dbo].[Chapter] ([Id], [ChapterName], [ChapterDescription], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1, N'Chapter 1', N'des', CAST(N'2018-03-16T13:38:36.620' AS DateTime), 1, CAST(N'2018-03-16T13:38:36.620' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Chapter] OFF
SET IDENTITY_INSERT [dbo].[Choice] ON 

INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (81, 3, N'Choice 1-1', 1, 1, 1, CAST(N'2018-03-16T14:16:08.393' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.393' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (82, 3, N'Choice 1-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (83, 3, N'Choice 1-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (84, 3, N'Choice 1-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (85, 4, N'Choice 2-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (86, 4, N'Choice 2-2', 1, 1, 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (87, 4, N'Choice 2-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.397' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (88, 4, N'Choice 2-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (89, 5, N'Choice 3-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (90, 5, N'Choice 3-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (91, 5, N'Choice 3-3', 1, 1, 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (92, 5, N'Choice 3-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (93, 6, N'Choice 4-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (94, 6, N'Choice 4-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (95, 6, N'Choice 4-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (96, 6, N'Choice 4-4', 1, 1, 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (97, 7, N'Choice 5-1', 1, 1, 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (98, 7, N'Choice 5-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (99, 7, N'Choice 5-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (100, 7, N'Choice 5-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (101, 8, N'Choice 6-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (102, 8, N'Choice 6-2', 1, 1, 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (103, 8, N'Choice 6-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (104, 8, N'Choice 6-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (105, 9, N'Choice 7-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (106, 9, N'Choice 7-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.400' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (107, 9, N'Choice 7-3', 1, 1, 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (108, 9, N'Choice 7-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (109, 10, N'Choice 8-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (110, 10, N'Choice 8-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (111, 10, N'Choice 8-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (112, 10, N'Choice 8-4', 1, 1, 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (113, 11, N'Choice 9-1', 1, 1, 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (114, 11, N'Choice 9-2', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (115, 11, N'Choice 9-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (116, 11, N'Choice 9-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (117, 12, N'Choice 10-1', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (118, 12, N'Choice 10-2', 1, 1, 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (119, 12, N'Choice 10-3', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
INSERT [dbo].[Choice] ([Id], [QuestionId], [ChoiceString], [Order], [IsJumble], [CorrentOrWrong], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (120, 12, N'Choice 10-4', 1, 1, 0, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1, CAST(N'2018-03-16T14:16:08.403' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Choice] OFF
SET IDENTITY_INSERT [dbo].[Exam] ON 

INSERT [dbo].[Exam] ([Id], [AlgorithmId], [Name], [Description], [TotalQuestions], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1, 1, N'', N'', 5, CAST(N'2018-03-16T17:00:44.503' AS DateTime), 1, CAST(N'2018-03-16T17:00:44.503' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Exam] OFF
SET IDENTITY_INSERT [dbo].[LoginUser] ON 

INSERT [dbo].[LoginUser] ([Id], [Email], [LoginUserName], [PhoneNumber], [Nic], [Password], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (2, N'nipuna@gmail.com', N'nipuna', 716948153, N'931663054v', N'nipuna', CAST(N'2018-03-16T16:48:29.470' AS DateTime), 1, CAST(N'2018-03-16T16:48:29.470' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[LoginUser] OFF
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (3, 1, N'This is Question 1', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:41:32.727' AS DateTime), 1, CAST(N'2018-03-16T13:41:32.727' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (4, 1, N'This is Question 2', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.350' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.350' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (5, 1, N'This is Question 3', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.350' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.350' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (6, 1, N'This is Question 4', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.350' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.350' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (7, 1, N'This is Question 5', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (8, 1, N'This is Question 6', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (9, 1, N'This is Question 7', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (10, 1, N'This is Question 8', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (11, 1, N'This is Question 9', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (12, 1, N'This is Question 10', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (13, 1, N'This is Question 11', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (14, 1, N'This is Question 12', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (15, 1, N'This is Question 13', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (16, 1, N'This is Question 14', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (17, 1, N'This is Question 15', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (18, 1, N'This is Question 16', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (19, 1, N'This is Question 17', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (20, 1, N'This is Question 18', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (21, 1, N'This is Question 19', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (22, 1, N'This is Question 20', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.353' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (23, 1, N'This is Question 21', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (24, 1, N'This is Question 22', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (25, 1, N'This is Question 23', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1)
INSERT [dbo].[Question] ([Id], [SectionId], [QuestionContent], [Explantion], [NumberOfChoices], [Priority], [CanRandomizeChoices], [DifficultyLevel], [Language], [Tag], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (26, 1, N'This is Question 24', N'', 4, 1, 1, 1, N'', N'', CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1, CAST(N'2018-03-16T13:43:47.357' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Question] OFF
SET IDENTITY_INSERT [dbo].[Sections] ON 

INSERT [dbo].[Sections] ([Id], [SectionName], [ChapterId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1, N'Section 1', 1, CAST(N'2018-03-16T13:41:13.710' AS DateTime), 1, CAST(N'2018-03-16T13:41:13.710' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Sections] OFF
SET IDENTITY_INSERT [dbo].[UserExamAttempt] ON 

INSERT [dbo].[UserExamAttempt] ([Id], [ExamId], [LoginUserId], [Attempt], [Marks], [PassofFail], [ExamDate], [Status], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (3, 1, 2, 0, 0, 0, CAST(N'2018-03-16T17:00:55.977' AS DateTime), 1, CAST(N'2018-03-16T17:00:55.977' AS DateTime), 1, CAST(N'2018-03-16T17:00:55.977' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[UserExamAttempt] OFF
SET IDENTITY_INSERT [dbo].[UserExamAttemptQuestion] ON 

INSERT [dbo].[UserExamAttemptQuestion] ([Id], [UserExamId], [QuestionId], [ChoiceId], [IsAnswered], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (16, 3, 3, 85, 0, CAST(N'2018-03-16T17:08:31.157' AS DateTime), 1, CAST(N'2018-03-16T17:08:31.157' AS DateTime), 1)
INSERT [dbo].[UserExamAttemptQuestion] ([Id], [UserExamId], [QuestionId], [ChoiceId], [IsAnswered], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (17, 3, 4, NULL, 0, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1)
INSERT [dbo].[UserExamAttemptQuestion] ([Id], [UserExamId], [QuestionId], [ChoiceId], [IsAnswered], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (18, 3, 5, NULL, 0, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1)
INSERT [dbo].[UserExamAttemptQuestion] ([Id], [UserExamId], [QuestionId], [ChoiceId], [IsAnswered], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (19, 3, 6, NULL, 0, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1)
INSERT [dbo].[UserExamAttemptQuestion] ([Id], [UserExamId], [QuestionId], [ChoiceId], [IsAnswered], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (20, 3, 7, NULL, 0, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1, CAST(N'2018-03-16T17:08:31.160' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[UserExamAttemptQuestion] OFF
ALTER TABLE [dbo].[Exam] ADD  DEFAULT ((0)) FOR [AlgorithmId]
GO
ALTER TABLE [dbo].[Question] ADD  DEFAULT ((0)) FOR [SectionId]
GO
ALTER TABLE [dbo].[UserExamAttempt] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[UserExamAttemptQuestion] ADD  DEFAULT ((0)) FOR [IsAnswered]
GO
ALTER TABLE [dbo].[Choice]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Choice_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Choice] CHECK CONSTRAINT [FK_dbo.Choice_dbo.Question_QuestionId]
GO
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Exam_dbo.Algorithms_AlgorithmId] FOREIGN KEY([AlgorithmId])
REFERENCES [dbo].[Algorithms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_dbo.Exam_dbo.Algorithms_AlgorithmId]
GO
ALTER TABLE [dbo].[ExamChapter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamChapter_dbo.Chapter_ChapterId] FOREIGN KEY([ChapterId])
REFERENCES [dbo].[Chapter] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExamChapter] CHECK CONSTRAINT [FK_dbo.ExamChapter_dbo.Chapter_ChapterId]
GO
ALTER TABLE [dbo].[ExamChapter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamChapter_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExamChapter] CHECK CONSTRAINT [FK_dbo.ExamChapter_dbo.Exam_ExamId]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Image_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_dbo.Image_dbo.Question_QuestionId]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Question_dbo.Sections_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Sections] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_dbo.Question_dbo.Sections_SectionId]
GO
ALTER TABLE [dbo].[SavedPapers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SavedPapers_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SavedPapers] CHECK CONSTRAINT [FK_dbo.SavedPapers_dbo.Exam_ExamId]
GO
ALTER TABLE [dbo].[SavedPapers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SavedPapers_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SavedPapers] CHECK CONSTRAINT [FK_dbo.SavedPapers_dbo.Question_QuestionId]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId] FOREIGN KEY([ChapterId])
REFERENCES [dbo].[Chapter] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId]
GO
ALTER TABLE [dbo].[UserExamAttempt]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserExamAttempt_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserExamAttempt] CHECK CONSTRAINT [FK_dbo.UserExamAttempt_dbo.Exam_ExamId]
GO
ALTER TABLE [dbo].[UserExamAttempt]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId] FOREIGN KEY([LoginUserId])
REFERENCES [dbo].[LoginUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserExamAttempt] CHECK CONSTRAINT [FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId]
GO
ALTER TABLE [dbo].[UserExamAttemptQuestion]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAttemptQuestion_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
GO
ALTER TABLE [dbo].[UserExamAttemptQuestion] CHECK CONSTRAINT [FK_UserExamAttemptQuestion_Question]
GO
ALTER TABLE [dbo].[UserExamAttemptQuestion]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAttemptQuestion_UserExamAttempt] FOREIGN KEY([UserExamId])
REFERENCES [dbo].[UserExamAttempt] ([Id])
GO
ALTER TABLE [dbo].[UserExamAttemptQuestion] CHECK CONSTRAINT [FK_UserExamAttemptQuestion_UserExamAttempt]
GO
