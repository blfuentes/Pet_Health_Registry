CREATE TABLE [dbo].[Breed] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [SpeciesId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Breed_ToSpecies] FOREIGN KEY ([SpeciesId]) REFERENCES [dbo].[Species] ([Id])
);

