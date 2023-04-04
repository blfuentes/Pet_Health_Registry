CREATE TABLE [dbo].[WeightRegistry] (
    [Id]         INT           NOT NULL IDENTITY,
    [PetId]      INT           NOT NULL,
    [RegisterOn] DATETIME2 (7) NOT NULL,
    [Weight]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_WeightRegistry_ToPet] FOREIGN KEY ([PetId]) REFERENCES [dbo].[Pets] ([Id])
);

