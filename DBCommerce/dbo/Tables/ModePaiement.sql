CREATE TABLE [dbo].[ModePaiement] (
    [ID_ModePaiement] INT           IDENTITY (1, 1) NOT NULL,
    [Paypal]          VARCHAR (255) NULL,
    [Visa]            VARCHAR (255) NULL,
    [Maestro]         VARCHAR (255) NULL,
    CONSTRAINT [PK_ModePaiement] PRIMARY KEY CLUSTERED ([ID_ModePaiement] ASC)
);

