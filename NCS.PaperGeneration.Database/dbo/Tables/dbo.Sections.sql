
CREATE TABLE [dbo].[Sections](
	[SectionId] [int] IDENTITY(1,1) NOT NULL,
	[SectionName] [nvarchar](max) NULL,
	[ChapterId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Sections] PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId] FOREIGN KEY([ChapterId])
REFERENCES [dbo].[Chapter] ([ChapterId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId]
GO
