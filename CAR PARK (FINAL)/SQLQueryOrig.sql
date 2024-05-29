USE ParkSys

CREATE TABLE Users (
    userId INT PRIMARY KEY IDENTITY(100, 1),
    userLN NVARCHAR(MAX),
    userFN NVARCHAR(MAX),
    userMI NVARCHAR(MAX),
    userNm NVARCHAR(MAX),
    userPW NVARCHAR(MAX)
);

SELECT * FROM Users

CREATE TABLE UserLogs (
    logId INT PRIMARY KEY IDENTITY(200, 1),
    userId INT,
    logDate DATETIME,
    FOREIGN KEY (userId) REFERENCES Users(userId)
);

SELECT * FROM UserLogs

DELETE FROM Vehicles;

DBCC CHECKIDENT ("Vehicles", RESEED, 200);

CREATE TABLE Vehicles (
    vehicId INT PRIMARY KEY IDENTITY(300, 1),
    userId INT,
    vehicPlate NVARCHAR(MAX),
    vehicType NVARCHAR(MAX),
    vehicBrand NVARCHAR(MAX),
    vehicParkinT NVARCHAR(MAX),
    vehicParkoutT NVARCHAR(MAX),
    vehicTotalhrs NVARCHAR(MAX),
    vehicTotalamnt NVARCHAR(MAX),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);

SELECT * FROM Vehicles

CREATE TABLE Slots (
    slotId INT PRIMARY KEY IDENTITY(400, 1),
    userId INT,
    vehicId INT,
    slotLoc NVARCHAR(MAX),
    slotOccpncy INT,
    FOREIGN KEY (userId) REFERENCES Users(userId),
    FOREIGN KEY (vehicId) REFERENCES Vehicles(vehicId)
);

UPDATE Slots SET userId = NULL, vehicId = NULL, slotOccpncy = 0 WHERE slotOccpncy = 1; 

INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 1, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 2, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 3, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 4, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 5, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 6, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 7, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 8, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 9, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 10, Floor 1', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 11, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 12, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 13, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 14, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 15, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 16, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 17, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 18, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 19, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 20, Floor 2', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 21, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 22, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 23, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 24, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 25, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 26, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 27, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 28, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 29, Floor 3', 0);
INSERT INTO Slots(userId, vehicId, slotLoc, slotOccpncy) VALUES (NULL, NULL, 'Slot 30, Floor 3', 0);

SELECT * FROM Slots

CREATE TABLE Transact (
    tranId INT PRIMARY KEY IDENTITY(500, 1),
    userId INT,
    vehicId INT,
    slotId INT,
    tranDate DATETIME,
    FOREIGN KEY (userId) REFERENCES Users(userId),
    FOREIGN KEY (vehicId) REFERENCES Vehicles(vehicId),
    FOREIGN KEY (slotId) REFERENCES Slots(slotId)
);

SELECT * FROM Transact