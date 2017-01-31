USE [NFLDB]
GO

-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Creates the QB stats table 

-- =============================================
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QBStats_2016](
	[Quarterback] [varchar](50) NULL,
	[Attempt] [int] NULL,
	[Completion] [int] NULL,
	[Yards] [int] NULL,
	[YardsPerAttempt] [decimal](18, 2) NULL,
	[Touchdown] [int] NULL,
	[Interception] [int] NULL,
	[Long] [int] NULL,
	[Sack] [int] NULL,
	[Loss] [int] NULL,
	[Rate] [decimal](18, 2) NULL,
	[TotalPoints] [int] NULL,
	[HomeOrAway] [varchar](50) NULL,
	[Year] [varchar](50) NULL
) ON [PRIMARY]

GO


