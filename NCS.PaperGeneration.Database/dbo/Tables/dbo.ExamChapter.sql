
CREATE TABLE [dbo].[ExamChapter](
	[ExamId] [int] NOT NULL,
	[ChapterId] [int] NOT NULL,
	[NumberOfQuestionsFromChapter] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_dbo.ExamChapter] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC,
	[ChapterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ExamChapter] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[ExamChapter] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[ExamChapter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamChapter_dbo.Chapter_ChapterId] FOREIGN KEY([ChapterId])
REFERENCES [dbo].[Chapter] ([ChapterId])
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
