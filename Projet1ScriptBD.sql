/*
Name : Projet1ScriptBD.sql
Vincent Contantin - Antoine Brassard Lahey
*/

use BD5B6TP1_ConstantinBrassardLahey;

/*
| Creation de la table TypeSoin
 */
CREATE TABLE TypeSoin
(
    NoTypeSoin INT NOT NULL,
    Description VARCHAR(75) NOT NULL,
	CONSTRAINT PK_TypeSoin PRIMARY KEY (NoTypeSoin,Description)
)
CREATE UNIQUE INDEX TypeSoin_NoTypeSoin_uindex ON TypeSoin (NoTypeSoin)

/*
| Creation de la table Soin
 */

CREATE TABLE Soin
(
    NoSoin INT PRIMARY KEY NOT NULL,
    Description VARCHAR(75),
    Duree TIME NOT NULL,
    NoTypeSoin INT NOT NULL FOREIGN KEY REFERENCES TypeSoin(NoTypeSoin),
    Prix NUMERIC(5,2) NOT NULL
)

/*
| Creation de la table Assistant
 */
CREATE TABLE Assistant
(
    NoAssistant INT PRIMARY KEY NOT NULL,
    Prenom VARCHAR(25) NOT NULL,
    Nom VARCHAR(25) NOT NULL,
    Specialites VARCHAR(20),
    Description VARCHAR(75)
)

/*
| Creation de la table AssistantSoin
 */
CREATE TABLE AssistantSoin
(
    NoAssistant INT NOT NULL,
    NoSoin INT NOT NULL,
	CONSTRAINT PK_AssistantSoin PRIMARY KEY (NoAssistant,NoSoin),
    CONSTRAINT AssistantSoin_Soin_NoSoin_fk FOREIGN KEY (NoSoin) REFERENCES Soin (NoSoin),
    CONSTRAINT AssistantSoin_Assistant_NoAssistant_fk FOREIGN KEY (NoAssistant) REFERENCES Assistant (NoAssistant)
)

/*
| Creation de la table Client
 */
CREATE TABLE Client
(
    NoClient INT PRIMARY KEY NOT NULL,
    Nom VARCHAR(25) NOT NULL,
    Prenom VARCHAR(25) NOT NULL,
    Ville VARCHAR(25) NOT NULL,
    Pays VARCHAR(25) NOT NULL,
    Adresse VARCHAR(25),
    CodePostal VARCHAR(25),
    Description VARCHAR(25) NOT NULL,
	CONSTRAINT CK_NoClient CHECK(NoClient%10 = 0) 
)
CREATE UNIQUE INDEX Client_NoCliet_uindex ON Client (NoClient)

/*
| Creation de la table Invite
 */
CREATE TABLE Invite
(
    NoInvite INT PRIMARY KEY NOT NULL,
    Nom VARCHAR(25) NOT NULL,
    Prenom VARCHAR(25) NOT NULL,
    NoClient INT,
    CONSTRAINT Invite_Client_NoCliet_fk FOREIGN KEY (NoClient) REFERENCES Client (NoClient),
	CONSTRAINT CK_NoInvite CHECK(NoInvite % 10 != 0),
	CONSTRAINT CK_NoInvite2 CHECK(Noclient - NoInvite >= 9)
)
CREATE UNIQUE INDEX Invite_NoInvite_uindex ON Invite (NoInvite)

/*
| Creation de la table TypeChambre
*/
CREATE TABLE TypeChambre
(
    NoTypeChambre INT PRIMARY KEY NOT NULL,
    Description VARCHAR(100),
    PrixHaut NUMERIC(5,2) NOT NULL,
    PrixBas NUMERIC(5,2) NOT NULL,
    PrixMoyen NUMERIC(5,2) NOT NULL
)
CREATE UNIQUE INDEX TypeChambre_NoTypeChambre_uindex ON TypeChambre (NoTypeChambre)

/*
| Creation de la table Chambre
*/
CREATE TABLE Chambre
(
    NoChambre INT PRIMARY KEY NOT NULL,
    Emplacement VARCHAR(25) NOT NULL,
    Decoration VARCHAR(25),
    NoTypeChambre INT NOT NULL,
    CONSTRAINT Chambre_TypeChambre_NoTypeChambre_fk FOREIGN KEY (NoTypeChambre) REFERENCES TypeChambre (NoTypeChambre)
)
CREATE UNIQUE INDEX Chambre_NoChambre_uindex ON Chambre (NoChambre)
CREATE UNIQUE INDEX Chambre_Emplacement_uindex ON Chambre (Emplacement)

/*
| Creation de la table ReservationChambre
 */
CREATE TABLE ReservationChambre
(
    NoClient INT NOT NULL,
    NoChambre INT NOT NULL,
    DateArrivee DATETIME NOT NULL,
    DateDepart DATETIME NOT NULL,
    NbPersonnes INT NOT NULL,
	CONSTRAINT PK_ReservationChambre PRIMARY KEY (NoClient,NoChambre,DateArrivee),
    CONSTRAINT ReservationChambre_Client_NoCliet_fk FOREIGN KEY (NoClient) REFERENCES Client (NoClient),
    CONSTRAINT ReservationChambre_Chambre_NoChambre_fk FOREIGN KEY (NoChambre) REFERENCES Chambre (NoChambre)
)
/*
| Creation de la table PlanifSoin
 */
CREATE TABLE PlanifSoin
(
    NoPersonne INT NOT NULL,
    NoAssistant INT NOT NULL,
    DateHeure DATETIME NOT NULL,
    NoSoin INT NOT NULL,
	CONSTRAINT PK_PlanifSoin PRIMARY KEY (NoPersonne,NoAssistant,DateHeure),
    CONSTRAINT PlanifSoin_Soin_NoSoin_fk FOREIGN KEY (NoSoin) REFERENCES Soin (NoSoin),
    CONSTRAINT PlanifSoin_Assistant_NoAssistant_fk FOREIGN KEY (NoAssistant) REFERENCES Assistant (NoAssistant),
	CONSTRAINT PlanifSoin_Invite_NoPersonne_fk FOREIGN KEY (NoPersonne) REFERENCES Invite (NoInvite),
    CONSTRAINT PlanifSoin_Client_NoPersonne_fk FOREIGN KEY (NoPersonne) REFERENCES Client (NoClient)
)
