CREATE TABLE questions
(
	[q_id] INT NOT NULL PRIMARY KEY, 
    [q_question] NCHAR(1000) NOT NULL, 
    [q_opA] NCHAR(100) NOT NULL, 
    [q_opB] NCHAR(100) NOT NULL, 
    [q_opC] NCHAR(100) NOT NULL, 
    [q_opD] NCHAR(100) NOT NULL, 
    [q_opcORRECT] NCHAR(100) NOT NULL
)
