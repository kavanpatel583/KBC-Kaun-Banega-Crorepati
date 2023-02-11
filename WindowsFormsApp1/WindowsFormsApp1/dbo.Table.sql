CREATE TABLE [dbo].[Table]
(
	[q_id] INT NOT NULL PRIMARY KEY, 
    [q_question] NCHAR(10) NOT NULL, 
    [q_opA] NCHAR(10) NOT NULL, 
    [q_opB] NCHAR(10) NOT NULL, 
    [q_opC] NCHAR(10) NOT NULL, 
    [q_opD] NCHAR(10) NOT NULL, 
    [q_opcORRECT] NCHAR(10) NOT NULL
)
