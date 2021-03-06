USE [DateTimeDatabase]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 6/13/2020 4:19:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[Identifier] [int] NULL,
	[StartDate] [datetime2](7) NULL,
	[StartTime] [datetime2](7) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomIdentifier], [Identifier], [StartDate], [StartTime]) VALUES (1, 100, CAST(N'2020-06-01T11:00:00.0000000' AS DateTime2), CAST(N'2020-06-01T11:00:00.0000000' AS DateTime2))
INSERT [dbo].[Room] ([RoomIdentifier], [Identifier], [StartDate], [StartTime]) VALUES (2, 100, CAST(N'2020-06-01T12:00:00.0000000' AS DateTime2), CAST(N'2020-06-01T12:00:00.0000000' AS DateTime2))
INSERT [dbo].[Room] ([RoomIdentifier], [Identifier], [StartDate], [StartTime]) VALUES (3, 100, CAST(N'2020-06-01T13:00:00.0000000' AS DateTime2), CAST(N'2020-06-01T13:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Room] OFF
