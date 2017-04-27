CREATE TABLE [dbo].[tblLanguage]
(
	[LanguageID] INT NOT NULL PRIMARY KEY, 
    [LanguageName] VARCHAR(25) NOT NULL, 
    [LanguageDescription] VARCHAR(MAX) NULL, 
    [LanguageStronglyTyped] BIT NULL
)
