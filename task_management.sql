CREATE DATABASE task_management
GO
USE task_management

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    DayOfBirth DATE,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(15)
);

CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    DayStart DATETIME NOT NULL,
    Deadline DATETIME NOT NULL,
    Status BIT NOT NULL DEFAULT 0,
    UserId INT NOT NULL,
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);