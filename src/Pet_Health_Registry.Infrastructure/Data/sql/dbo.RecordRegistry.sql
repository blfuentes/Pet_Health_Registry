CREATE TABLE [dbo].[RecordRegistry] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [PetId]       INT            NOT NULL,
    [RegisterOn]  DATETIME2 (7)  NOT NULL,
    [Value]       INT            NULL,
    [Description] NVARCHAR (50)  NULL,
    [Notes]       NVARCHAR (MAX) NULL,
    [RegistryTypeId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RecordRegistry_ToPet] FOREIGN KEY ([PetId]) REFERENCES [dbo].[Pets] ([Id]), 
    CONSTRAINT [FK_RecordRegistry_ToRegistryType] FOREIGN KEY ([RegistryTypeId]) REFERENCES [RegistryType]([Id])
);

