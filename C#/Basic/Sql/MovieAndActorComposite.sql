CREATE TABLE Movie
(
MovieID int PRIMARY KEY NOT NULL,
MovieName varchar(255),
MovieLanguage varchar(255),
MovieYear int
);

CREATE TABLE Actor
(
ActorID int PRIMARY KEY NOT NULL,
ActorName varchar(255),
ActorGender varchar(255),
);

CREATE TABLE Movie_Actor_Map
(
                         
 MovieId int FOREIGN KEY REFERENCES Movie(MovieId), 
 ActorId int FOREIGN KEY REFERENCES Actor(ActorId), 	
);				  

INSERT INTO Movie VALUES('01','Ramayana','Hindi','2002')
INSERT INTO Movie VALUES('02','Geeta','Hindi','2000')
INSERT INTO Movie VALUES('03','Mahabharat','Hindi','2003')
INSERT INTO Movie VALUES('04','Om','Hindi','2001')
	   
INSERT INTO Actor VALUES('11','Valmiki','MALE')
INSERT INTO Actor VALUES('12','Vyasadeva','MALE')
INSERT INTO Actor VALUES('13','Valmiki','MALE')	   
INSERT INTO Actor VALUES('14','Sachdeva','MALE')
 

SELECT * FROM Movie
SELECT * FROM Actor

