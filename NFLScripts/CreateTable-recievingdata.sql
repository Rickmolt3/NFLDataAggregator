USE [NFLDB]
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Creates the recievingdata table

-- =============================================
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[recievingdata](
	[Rank] [int] NULL,
	[Player] [nvarchar](255) NULL,
	[Position] [nvarchar](255) NULL,
	[Team] [nvarchar](255) NULL,
	[Receptions] [int] NULL,
	[Targets] [int] NULL,
	[Yards] [int] NULL,
	[Average] [int] NULL,
	[TD] [int] NULL,
	[LONG] [int] NULL,
	[20+] [int] NULL,
	[YardsAGame] [int] NULL,
	[Fumble] [int] NULL,
	[YardsAfterCatch] [int] NULL,
	[FirstDowns] [int] NULL
) ON [PRIMARY]

GO


