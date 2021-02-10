CREATE TABLE [dbo].[Client] (
    [ID_Client]     INT           IDENTITY (1, 1) NOT NULL,
    [Nom]           VARCHAR (255) NOT NULL,
    [Prenom]        VARCHAR (255) NOT NULL,
    [Sexe]          VARCHAR (2)   NOT NULL,
    [Adresse]       VARCHAR (255) NOT NULL,
    [Telephone]     VARCHAR (255) NOT NULL,
    [Email]         VARCHAR (255) NOT NULL,
    [DateNaissance] DATE          NOT NULL,
    [CodePostal]    VARCHAR (16)  NOT NULL,
    [Pays]          VARCHAR (255) NOT NULL,
    [Ville]         VARCHAR (255) NOT NULL,
    [Pseudo]        VARCHAR (16)  NOT NULL,
    [MotDePass]     VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([ID_Client] ASC)
);

