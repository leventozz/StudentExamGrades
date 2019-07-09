
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/09/2019 10:12:35
-- Generated from EDMX file: D:\Visual Studio Projeler\ExamGradesApplication\ExamGradesApplication\DB\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StudentInformationSystemDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ExamGrades_Lessons1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExamGrades] DROP CONSTRAINT [FK_ExamGrades_Lessons1];
GO
IF OBJECT_ID(N'[dbo].[FK_ExamGrades_Students1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExamGrades] DROP CONSTRAINT [FK_ExamGrades_Students1];
GO
IF OBJECT_ID(N'[dbo].[FK_Teachers_Lessons2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teachers] DROP CONSTRAINT [FK_Teachers_Lessons2];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ExamGrades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExamGrades];
GO
IF OBJECT_ID(N'[dbo].[Lessons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lessons];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Teachers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teachers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExamGrades'
CREATE TABLE [dbo].[ExamGrades] (
    [StudentID] int  NOT NULL,
    [LessonID] int  NOT NULL,
    [ExamGrade1] int  NULL,
    [ExamGrades] int  NULL
);
GO

-- Creating table 'Lessons'
CREATE TABLE [dbo].[Lessons] (
    [LessonID] int IDENTITY(1,1) NOT NULL,
    [LessonName] nvarchar(50)  NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StudentID] int IDENTITY(1,1) NOT NULL,
    [StudentName] nvarchar(50)  NULL,
    [StudentLastName] nvarchar(50)  NULL,
    [StudentIdentificationNumber] int  NULL,
    [StudentPassword] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Teachers'
CREATE TABLE [dbo].[Teachers] (
    [TeacherID] int IDENTITY(1,1) NOT NULL,
    [TeacherName] nvarchar(50)  NULL,
    [TeacherLastName] nvarchar(50)  NULL,
    [TeacherIdentificationNumber] nvarchar(12)  NULL,
    [TeacherPassword] int  NULL,
    [LessonID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StudentID], [LessonID] in table 'ExamGrades'
ALTER TABLE [dbo].[ExamGrades]
ADD CONSTRAINT [PK_ExamGrades]
    PRIMARY KEY CLUSTERED ([StudentID], [LessonID] ASC);
GO

-- Creating primary key on [LessonID] in table 'Lessons'
ALTER TABLE [dbo].[Lessons]
ADD CONSTRAINT [PK_Lessons]
    PRIMARY KEY CLUSTERED ([LessonID] ASC);
GO

-- Creating primary key on [StudentID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [TeacherID] in table 'Teachers'
ALTER TABLE [dbo].[Teachers]
ADD CONSTRAINT [PK_Teachers]
    PRIMARY KEY CLUSTERED ([TeacherID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LessonID] in table 'ExamGrades'
ALTER TABLE [dbo].[ExamGrades]
ADD CONSTRAINT [FK_ExamGrades_Lessons1]
    FOREIGN KEY ([LessonID])
    REFERENCES [dbo].[Lessons]
        ([LessonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamGrades_Lessons1'
CREATE INDEX [IX_FK_ExamGrades_Lessons1]
ON [dbo].[ExamGrades]
    ([LessonID]);
GO

-- Creating foreign key on [StudentID] in table 'ExamGrades'
ALTER TABLE [dbo].[ExamGrades]
ADD CONSTRAINT [FK_ExamGrades_Students1]
    FOREIGN KEY ([StudentID])
    REFERENCES [dbo].[Students]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [LessonID] in table 'Teachers'
ALTER TABLE [dbo].[Teachers]
ADD CONSTRAINT [FK_Teachers_Lessons2]
    FOREIGN KEY ([LessonID])
    REFERENCES [dbo].[Lessons]
        ([LessonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Teachers_Lessons2'
CREATE INDEX [IX_FK_Teachers_Lessons2]
ON [dbo].[Teachers]
    ([LessonID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------