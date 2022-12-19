CREATE TABLE [dbo].[Laps](
	[Id] [uniqueidentifier] NOT NULL,
	[DriverName] [nvarchar](512) NULL,
	[LapIndex] [int] NOT NULL,
	[Sector] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ElapsedTime] [bigint] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Invalid] [bit] NOT NULL,
	[Session] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Laps] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Laps] ADD  CONSTRAINT [DF_Laps_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO

ALTER TABLE [dbo].[Laps] ADD  CONSTRAINT [DF_Laps_Invalid]  DEFAULT ((0)) FOR [Invalid]
GO

