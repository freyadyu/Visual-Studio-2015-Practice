CREATE TABLE [dbo].[StudentDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[StudentName] [nvarchar](20) NOT NULL,
	[StudentGender] [nvarchar](10) NOT NULL
) ON [PRIMARY]

GO

