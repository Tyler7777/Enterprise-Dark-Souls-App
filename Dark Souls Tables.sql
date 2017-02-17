DROP TABLE Class
DROP TABLE Chest
DROP TABLE Covenant
DROP TABLE Hands
DROP TABLE Head
DROP TABLE Legs
DROP TABLE Rings
DROP TABLE Weapons

CREATE TABLE Class(
Class_Name Varchar(50) NOT NULL primary key,
Soul_Level int NOT NULL,
Vigor int NOT NULL,
Attunement int NOT NULL,
Endurance int NOT NULL,
Vitality int NOT NULL,
Strength int NOT NULL,
Dexterity int NOT NULL,
Intelligence int NOT NULL,
Faith int NOT NULL,
Luck int NOT NULL
)

CREATE TABLE Head(
Name Varchar(50) NOT NULL PRIMARY KEY,
Physical int NOT NULL,
Strike int NOT NULL,
Slash int NOT NULL,
Thrust int NOT NULL,
Magic int NOT NULL,
Fire int NOT NULL,
Lightning int NOT NULL,
Dark int NOT NULL,
Bleed int NOT NULL,
Posion int NOT NULL,
Frost int NOT NULL,
Curse int NOT NULL,
Poise int NOT NULL,
Carry_Weight int NOT NULL
)
------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Hands(
Name Varchar(50) NOT NULL PRIMARY KEY,
Physical int NOT NULL,
Strike int NOT NULL,
Slash int NOT NULL,
Thrust int NOT NULL,
Magic int NOT NULL,
Fire int NOT NULL,
Lightning int NOT NULL,
Dark int NOT NULL,
Bleed int NOT NULL,
Posion int NOT NULL,
Frost int NOT NULL,
Curse int NOT NULL,
Poise int NOT NULL,
Carry_Weight int NOT NULL
)

CREATE TABLE Legs(
Name Varchar(50) NOT NULL PRIMARY KEY,
Physical int NOT NULL,
Strike int NOT NULL,
Slash int NOT NULL,
Thrust int NOT NULL,
Magic int NOT NULL,
Fire int NOT NULL,
Lightning int NOT NULL,
Dark int NOT NULL,
Bleed int NOT NULL,
Posion int NOT NULL,
Frost int NOT NULL,
Curse int NOT NULL,
Poise int NOT NULL,
Carry_Weight int NOT NULL
)

CREATE TABLE Chest(
Name Varchar(50) NOT NULL PRIMARY KEY,
Physical int NOT NULL,
Strike int NOT NULL,
Slash int NOT NULL,
Thrust int NOT NULL,
Magic int NOT NULL,
Fire int NOT NULL,
Lightning int NOT NULL,
Dark int NOT NULL,
Bleed int NOT NULL,
Posion int NOT NULL,
Frost int NOT NULL,
Curse int NOT NULL,
Poise int NOT NULL,
Carry_Weight int NOT NULL
)

CREATE TABLE Weapons(
Name Varchar(50) NOT NULL PRIMARY KEY,
Physical int NOT NULL,
Weapon_Type varchar(35) NOT NULL,
Attack_Type Varchar(35) NOT NULL,
Magic int NOT NULL,
Fire int NOT NULL,
Lightning int NOT NULL,
Dark int NOT NULL,
Bleed int NOT NULL,
Posion int NOT NULL,
Frost int NOT NULL,
Curse int NOT NULL,
Poise int NOT NULL,
Carry_Weight int NOT NULL
)

GO  
EXEC sp_RENAME 'Weapons.[Critical]' , '[Critical]'  

ALTER TABLE Weapons ADD Bleed int NULL

------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Rings(
Name VARCHAR(50) NOT NULL PRIMARY KEY,
Effects VARCHAR(400) NOT NULL
)

------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Shields(
Name Varchar(50) NOT NULL PRIMARY KEY,
Physical int NOT NULL,
Physical_Defense int NOT NULL,
Weapon_Type varchar(35) NOT NULL,
Attack_Type Varchar(35) NOT NULL,
Magic_Defense int NOT NULL,
Fire_Defense int NOT NULL,
Lightning_Defense int NOT NULL,
Dark_Defense int NOT NULL,
Stability int NOT NULL,
Carry_Weight int NOT NULL
)