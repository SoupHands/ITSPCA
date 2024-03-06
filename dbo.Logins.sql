CREATE TABLE [dbo].[Logins] (
    [UserID]     VARCHAR (25) NOT NULL,
    [Password]   VARCHAR (30) NOT NULL,
    [TimeIn]     DATETIME     NULL,
    [TimeOut]    DATETIME     NULL,
    [WorkDay]    DATE         NULL,
    [TotalHours] TIME (7)     NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

