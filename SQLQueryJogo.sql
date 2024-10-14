CREATE DATABASE GreciaGames;
USE GreciaGames;

CREATE TABLE Personagens(
    PersonId INT NOT NULL PRIMARY KEY IDENTITY,
	PersonName VARCHAR(30) NOT NULL,
    PersonTexto VARCHAR(200) NOT NULL,
	PersonOpc1 VARCHAR(100) NOT NULL,
	PersonOpc2 VARCHAR(100) NOT NULL
);

CREATE TABLE Medidores(
    MedidorId INT NOT NULL PRIMARY KEY IDENTITY,
	PersonId INT NOT NULL,
	EstatisMantimentos INT,
	EstatisExercito INT,
	EstatisConfianca INT,
	FOREIGN KEY(PersonId) REFERENCES Personagens(PersonId)
);

INSERT INTO Personagens VALUES('Eryx', 'General, uma tempestade se aproxima, deveriamos esperar ela passar?', 'Abrigar-se até a tempestade passar.', 'Prosseguir para economizar tempo.');
INSERT INTO Personagens VALUES('Calista', 'A chuva passada alagou o rio que atravessaríamos', 'Improvisar uma jangada para passar.', 'Esperar a água abaixar.');
INSERT INTO Personagens VALUES('Agapetos', 'General, avistei pelotão inimigo proximo das nossas tropas.', 'Preparar uma emboscada', 'Contornar pelo caminho mais longo.');

INSERT INTO Medidores VALUES(1, -15, NULL, 25);
INSERT INTO Medidores VALUES(1, 10, -10, -30);


INSERT INTO Medidores VALUES(2, 10, NULL, 5);
INSERT INTO Medidores VALUES(2, 15, NULL, 2);

INSERT INTO Medidores VALUES(3, 30, -5, 10);
INSERT INTO Medidores VALUES(3, -20, NULL, 5);

alter table Medidores
ADD MedidorId INT NOT NULL PRIMARY KEY IDENTITY;
