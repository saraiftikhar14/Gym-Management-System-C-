USE gym;
GO
create table Equipment
(
EID int not null IDENTITY(1,1) primary key,
EquipName VARCHAR(250) NOT NULL,
EDescription VARCHAR(250) NOT NULL,
MUsed VARCHAR(450) NOT NULL,
DDate VARCHAR(150) NOT NULL,
Cost BIGINT NOT NULL,
);
SELECT * FROM Equipment;