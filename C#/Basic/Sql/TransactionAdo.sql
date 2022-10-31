CREATE TABLE Accounts
(
     AccountNumber VARCHAR(60) PRIMARY KEY,
     CustomerName VARCHAR(60),
     Balance int
)

INSERT INTO Accounts VALUES('Account1', 'James', 1000);
INSERT INTO Accounts VALUES('Account2', 'Smith', 1000);

SELECT *From Accounts