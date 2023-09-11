CREATE TABLE [dbo].[TAgency] (
    [designation]  VARCHAR (50) NOT NULL,
    [localisation] VARCHAR (50) NOT NULL,
    [statut]       VARCHAR (50) NOT NULL, 
    [id] INT NOT NULL, 
    CONSTRAINT [PK_TAgency] PRIMARY KEY ([id])
);

