CREATE DATABASE TEST
GO
USE TEST
GO
CREATE TABLE PERSON(
Id int IDENTITY (1,1) not null,
Name varchar(25) not null,
Date_of_birth date
);
GO
INSERT INTO DBO.PERSON VALUES('Elian Martinez', '2000-12-12');
INSERT INTO DBO.PERSON VALUES('Karen Gonzalez', '2003-01-04');
INSERT INTO DBO.PERSON VALUES('Juan Perez', '2000-10-11');

SELECT * FROM DBO.PERSON;