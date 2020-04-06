CREATE TABLE [dbo].[CorpDetails] (
    [CourseID] INT           IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (50) NULL,
    [Credits]  INT           NULL,
    PRIMARY KEY CLUSTERED ([CourseID] ASC)
)