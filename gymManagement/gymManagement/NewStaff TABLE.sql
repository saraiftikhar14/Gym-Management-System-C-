USE gym; -- Ensure you are using the correct database
GO

CREATE TABLE NewStaff
(
    SID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Fname VARCHAR(150) NOT NULL,
    Lname VARCHAR(150) NOT NULL,
    Gender VARCHAR(20) NOT NULL,
    Dob VARCHAR(100) NOT NULL,
    Mobile BIGINT NOT NULL,
    Email VARCHAR(150),
    JoinDate VARCHAR(100) NOT NULL,
    Statee VARCHAR(100) NOT NULL,
    City VARCHAR(100) NOT NULL
);

SELECT * FROM NewStaff;
