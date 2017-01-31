USE [NFLDB]
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Creates the runningbackdata table

-- =============================================
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[runningbackdata](
	[Rank] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Team] [varchar](50) NULL,
	[Age] [varchar](50) NULL,
	[Position] [varchar](50) NULL,
	[Games] [varchar](50) NULL,
	[GamesStarted] [varchar](50) NULL,
	[RushAttempts] [varchar](50) NULL,
	[RushYds] [varchar](50) NULL,
	[RushTD] [varchar](50) NULL,
	[RushLng] [varchar](50) NULL,
	[RushYA] [varchar](50) NULL,
	[RushYG] [varchar](50) NULL,
	[RushAG] [varchar](50) NULL,
	[RecTargets] [varchar](50) NULL,
	[Rec] [varchar](50) NULL,
	[RecYds] [varchar](50) NULL,
	[RecYR] [varchar](50) NULL,
	[RecTD] [varchar](50) NULL,
	[RecLng] [varchar](50) NULL,
	[RecRG] [varchar](50) NULL,
	[RecYG] [varchar](50) NULL,
	[Catch%] [varchar](50) NULL,
	[ScrimageYds] [varchar](50) NULL,
	[TotalTds] [varchar](50) NULL,
	[Fumble] [varchar](50) NULL
) ON [PRIMARY]

GO


