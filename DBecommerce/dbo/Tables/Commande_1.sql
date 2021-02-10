CREATE TABLE [dbo].[Commande] (
    [ID_Commande]                    INT        IDENTITY (1, 1) NOT NULL,
    [Date]                           DATE       NOT NULL,
    [Montant]                        FLOAT (53) NOT NULL,
    [Etat]                           BIT        NOT NULL,
    [PrixLivraison]                  FLOAT (53) NOT NULL,
    [DelaiLivraison]                 INT        NOT NULL,
    [Mode_LivraisonID_ModeLivraison] INT        NOT NULL,
    [Mode_PaiementID_ModePaiement]   INT        NOT NULL,
    CONSTRAINT [PK_Commande] PRIMARY KEY CLUSTERED ([ID_Commande] ASC),
    CONSTRAINT [FK_Commande_ModeLivraison] FOREIGN KEY ([Mode_LivraisonID_ModeLivraison]) REFERENCES [dbo].[ModeLivraison] ([ID_ModeLivraison]),
    CONSTRAINT [FK_Commande_ModePaiement] FOREIGN KEY ([Mode_PaiementID_ModePaiement]) REFERENCES [dbo].[ModePaiement] ([ID_ModePaiement])
);

