CREATE TABLE [dbo].[CommandeProduit] (
    [CommandeID_Commande] INT NOT NULL,
    [ProduitID_Produit]   INT NOT NULL,
    CONSTRAINT [FK_CommandeProduit_Commande] FOREIGN KEY ([CommandeID_Commande]) REFERENCES [dbo].[Commande] ([ID_Commande]),
    CONSTRAINT [FK_CommandeProduit_Produit] FOREIGN KEY ([ProduitID_Produit]) REFERENCES [dbo].[Produit] ([ID_Produit])
);



