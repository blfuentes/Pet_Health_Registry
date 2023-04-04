CREATE TABLE [dbo].[Pets] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [BirthDate]    DATETIME2 (7) NULL,
    [AdoptionDate] DATETIME2 (7) NOT NULL,
    [BreedId]      INT           NOT NULL,
    [DeathDate] DATETIME2 NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pets_ToBreed] FOREIGN KEY ([BreedId]) REFERENCES [dbo].[Breed] ([Id])
);

