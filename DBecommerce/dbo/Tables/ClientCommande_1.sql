CREATE TABLE [dbo].[ClientCommande] (
    [ClientID_Client]     INT NOT NULL,
    [CommandeID_Commande] INT NOT NULL,
    CONSTRAINT [FK_ClientCommande_Client] FOREIGN KEY ([ClientID_Client]) REFERENCES [dbo].[Client] ([ID_Client]),
    CONSTRAINT [FK_ClientCommande_Commande] FOREIGN KEY ([CommandeID_Commande]) REFERENCES [dbo].[Commande] ([ID_Commande])
);

