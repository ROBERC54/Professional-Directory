CREATE TABLE [dbo].[Files] (
    [EnrollmentID] INT IDENTITY (1, 1) NOT NULL,
    [Ranking]        DECIMAL(3, 2) NULL,
    [IndustryID]     INT NOT NULL,
    [ContactID]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([EnrollmentID] ASC),
    CONSTRAINT [FK_dbo.Files_dbo.Industry_IndustryID] FOREIGN KEY ([IndustryID]) 
        REFERENCES [dbo].[Industry] ([IndustryID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Files_dbo.Contact_ContactID] FOREIGN KEY ([ContactID]) 
        REFERENCES [dbo].[Contact] ([ContactID]) ON DELETE CASCADE
)