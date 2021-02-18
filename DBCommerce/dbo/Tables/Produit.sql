CREATE TABLE [dbo].[Produit] (
    [ID_Produit]            INT           IDENTITY (1, 1) NOT NULL,
    [Libellé]               VARCHAR (255) NOT NULL,
    [Description]           VARCHAR (255) NOT NULL,
    [Prix]                  FLOAT (53)    NOT NULL,
    [QuantiteDisponible]    FLOAT (53)    NOT NULL,
    [Image]                 VARCHAR (255) NULL,
    [Taxe]                  FLOAT (53)    NOT NULL,
    [Devise]                VARCHAR (50)  NOT NULL,
    [DateAjout]             DATE          NOT NULL,
    [EAN]                   VARCHAR (13)  NULL,
    [CategorieID_Categorie] INT           NOT NULL,
    CONSTRAINT [PK_Produit] PRIMARY KEY CLUSTERED ([ID_Produit] ASC),
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([CategorieID_Categorie]) REFERENCES [dbo].[Categorie] ([ID_Categorie])
);



