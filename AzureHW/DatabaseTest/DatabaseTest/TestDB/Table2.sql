CREATE TABLE [dbo].[Table2]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Table1Id] INT NULL, 
    [DataForTable2] DATETIME NULL, 
    CONSTRAINT [FK_Table2_ToTable] FOREIGN KEY ([Table1Id]) REFERENCES [Table1]([Id])
)
