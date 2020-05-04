CREATE TABLE [dbo].[Contact] (
    [ContactID]      INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [Age]            Int           NOT NULL DEFAULT 0,
    [EnrollmentDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([ContactID] ASC)
)