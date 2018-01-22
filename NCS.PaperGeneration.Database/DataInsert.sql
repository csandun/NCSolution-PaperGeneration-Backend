/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[Algorithms]
           ([Name]
           ,[Description]
           ,[CreatedDate]
           ,[CreatedBy]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('algo1'
           ,'algo 1'
           ,'2018-01-22'
           ,1
           ,null
           ,null);

INSERT into [dbo].[Exam]  (
		   [Name]
		   ,[Description]
           ,[TotalQuestions]
           ,[CreatedDate]
           ,[CreatedBy]
           ,[UpdatedDate]
           ,[UpdatedBy]
           ,[AlgorithmId])
VALUES ('Exam 1','Default 1', 60, '2018-01-23', 1, NULL, NULL, 1);

INSERT into [dbo].[Exam] (
		   [Name]
		   ,[Description]
           ,[TotalQuestions]
           ,[CreatedDate]
           ,[CreatedBy]
           ,[UpdatedDate]
           ,[UpdatedBy]
           ,[AlgorithmId])
VALUES ('Exam 2','Default 2', 50, '2018-01-23', 1, NULL, NULL, 1);