CREATE TABLE [dbo].[tblLanguageCONS]
(
	[ConID] INT NOT NULL PRIMARY KEY, 
    [LanguageID] INT NOT NULL, 
    [ConDescription] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_tblLanguageCONS_tblLanguage] FOREIGN KEY ([LanguageID]) REFERENCES [tblLanguage]([LanguageID])
)
