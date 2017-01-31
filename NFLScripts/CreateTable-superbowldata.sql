USE [NFLDB]
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Creates the superbowldata table

-- =============================================
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[superbowldata](
	[Date] [varchar](50) NULL,
	[SB] [varchar](50) NULL,
	[Winner] [varchar](50) NULL,
	[Pts] [varchar](50) NULL,
	[Loser] [varchar](50) NULL,
	[LoserPts] [varchar](50) NULL,
	[MVP] [varchar](50) NULL,
	[Stadium] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](50) NULL
) ON [PRIMARY]

GO


