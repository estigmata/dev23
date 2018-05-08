/*Create or insert if not exists a Role into the selected database*/
USE $(database)
IF NOT EXISTS(SELECT * FROM Roles WHERE Roles.Name='$(roleName)')
    INSERT INTO Roles(Name, Url) 
    VALUES('$(roleName)', '$(roleUrl)');
ELSE
BEGIN
    UPDATE Roles 
    SET Roles.Name='$(roleName)', Roles.Url='$(roleUrl)'
    WHERE Roles.Name='$(roleName)'
END