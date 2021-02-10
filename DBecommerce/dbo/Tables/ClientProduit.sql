CREATE TABLE [dbo].[ClientProduit] (
    [ClientID_Client]   INT NOT NULL,
    [ProduitID_Produit] INT NOT NULL,
    CONSTRAINT [FK_ClientProduit_Client] FOREIGN KEY ([ClientID_Client]) REFERENCES [dbo].[Client] ([ID_Client]),
    CONSTRAINT [FK_ClientProduit_Produit] FOREIGN KEY ([ProduitID_Produit]) REFERENCES [dbo].[Produit] ([ID_Produit])
);

