CREATE TABLE [dbo].[ModeLivraison] (
    [ID_ModeLivraison] INT           IDENTITY (1, 1) NOT NULL,
    [Poste]            VARCHAR (255) NULL,
    [Coursier]         VARCHAR (255) NULL,
    [Express]          VARCHAR (255) NULL,
    [PointRelais]      VARCHAR (255) NULL,
    CONSTRAINT [PK_ModeLivraison] PRIMARY KEY CLUSTERED ([ID_ModeLivraison] ASC)
);

