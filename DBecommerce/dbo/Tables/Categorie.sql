CREATE TABLE [dbo].[Categorie] (
    [ID_Categorie] INT           IDENTITY (1, 1) NOT NULL,
    [Libellé]      VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Categorie] PRIMARY KEY CLUSTERED ([ID_Categorie] ASC)
);

