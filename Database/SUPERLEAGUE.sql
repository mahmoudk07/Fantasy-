-------------Database creation-------------
--create database SuperLeague
Create database SuperLeague
GO
use SuperLeague

------------Table Creation-----------------
CREATE TABLE FMatch
(
  Away_Team varchar(50),
  Match_ID INT NOT NULL,
  Home_Team varchar(50),
  Stadium varchar(50),
  MDate date NOT NULL,
  Referee_ID int,
  season int,
  PRIMARY KEY (Match_ID)
);

CREATE TABLE Tickets_Availability
(
  Stat varchar(50) NOT NULL,
  Match_ID INT NOT NULL,
  PRIMARY KEY (Match_ID),
  FOREIGN KEY (Match_ID) REFERENCES FMatch(Match_ID) on delete cascade on update cascade 
);

CREATE TABLE Transfer_Market
(
  Transfer_Code INT NOT NULL,
  Player_ID int NOT NULL,
  Season int NOT NULL,
  TLeft varchar(50) NOT NULL,
  TJoined varchar(50) NOT NULL,
  Fee INT NOT NULL,
  TDate date NOT NULL,
  PRIMARY KEY (Transfer_Code)
);

CREATE TABLE Tournament
(
  Pfirst varchar(50) NOT NULL,
  PSecond varchar(50) NOT NULL,
  Number_of_Clubs_ INT,
  Sponsor_name varchar(50),
  Season INT NOT NULL,
  Stat varchar(50) NOT NULL,
  PRIMARY KEY (Season), 
);

CREATE TABLE Tournament_Admin
(
  Fname varchar(50) NOT NULL,
  Lname varchar(50) NOT NULL,
  ID INT NOT NULL,
  Season INT,
  PRIMARY KEY (ID,Season),
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action
);

------------------------MULTIVALUED RELATION OF TOURNAMENT-----------------------------------
CREATE TABLE Tournament_ClubID
(
  ClubID INT NOT NULL,
  Season INT NOT NULL,
  PRIMARY KEY (ClubID, Season),
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action 
);

CREATE TABLE Football_Club
(
  Club_Budget varchar(50) NOT NULL,
  Club_ID INT NOT NULL,
  Foundation_Date INT,
  Club_Name varchar(50) NOT NULL,
  City varchar(50),
  PRIMARY KEY (Club_ID),
  UNIQUE (Club_Name)
);

CREATE TABLE Football_Player
(
  Fname varchar(50) NOT NULL,
  Lname varchar(50) NOT NULL,
  Nationality varchar(50) NOT NULL,
  Age INT NOT NULL,
  Salary varchar(50),
  PRole varchar(50),
  Goals INT NOT NULL,
  Shirt_Number INT,
  Assists INT NOT NULL,
  ID INT NOT NULL,
  Market_Value varchar(50),
  Player_Position varchar(50) NOT NULL,
  Club_ID INT,
  Season INT NOT NULL,
  PRIMARY KEY (ID, Season),
  FOREIGN KEY (Club_ID) REFERENCES Football_Club(Club_ID) on delete no action on update cascade,
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action
);

CREATE TABLE Stadium
(
  Capacity varchar(50) NOT NULL,
  Stadium_Name varchar(50) NOT NULL default 'SAN SIRO',
  City varchar(50) NOT NULL,
  Construtction_Date INT NOT NULL,
  Club_ID INT,
  PRIMARY KEY (Stadium_Name),
  FOREIGN KEY (Club_ID) REFERENCES Football_Club(Club_ID) on delete no action on update cascade
);

CREATE TABLE Sponsor
(
  Sponsor_Name varchar(50) NOT NULL,
  Sponsor_ID INT NOT NULL,
  Season INT NOT NULL,
  PRIMARY KEY (Sponsor_ID),
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action,
  UNIQUE (Sponsor_Name) 
);

CREATE TABLE Coach
(
  Salary varchar(50),
  Age INT NOT NULL,
  Coach_ID INT NOT NULL,
  Fname varchar(50) NOT NULL,
  Lname varchar(50) NOT NULL,
  Nationality varchar(50) NOT NULL,
  Club_ID INT,
  Season INT NOT NULL,
  PRIMARY KEY (Coach_ID, Season),
  FOREIGN KEY (Club_ID) REFERENCES Football_Club(Club_ID) on delete no action on update cascade,
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action
);

CREATE TABLE Referee
(
  Yellow_Cards INT  NOT NULL,
  Red_Cards INT  NOT NULL,
  Awarded_Penalties INT  NOT NULL,
  Fname varchar(50) NOT NULL,
  Lname varchar(50) NOT NULL,
  Referee_ID INT default 1 NOT NULL,
  Season INT NOT NULL,
  PRIMARY KEY (Referee_ID, Season),
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action 
);

CREATE TABLE Standings
(
  Goals INT NOT NULL,
  wins INT NOT NULL,
  loses INT NOT NULL,
  Draw INT NOT NULL,
  Clean_Sheet INT NOT NULL,
  Matches_Played INT NOT NULL,
  Points INT NOT NULL,
 -- TRank INT NOT NULL,
  Club_Name varchar(50) NOT NULL,
  Season INT NOT NULL,
  PRIMARY KEY (Club_Name, Season),
  FOREIGN KEY (Club_Name) REFERENCES Football_Club(Club_Name) on delete no action on update cascade,
  FOREIGN KEY (Season) REFERENCES Tournament(Season) on delete no action on update no action
);

CREATE TABLE Club_Admin
(
  Fname varchar(50) NOT NULL,
  Lanme varchar(50) NOT NULL,
  ID INT NOT NULL,
  Club_ID INT NOT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (Club_ID) REFERENCES Football_Club(Club_ID) on delete no action on update cascade
);

CREATE TABLE Has
(
  Str_Date INT NOT NULL,
  End_date INT,
  Club_ID INT NOT NULL,
  Sponsor_ID INT NOT NULL,
  PRIMARY KEY (Club_ID, Sponsor_ID),
  FOREIGN KEY (Club_ID) REFERENCES Football_Club(Club_ID) on delete no action on update cascade,
  FOREIGN KEY (Sponsor_ID) REFERENCES Sponsor(Sponsor_ID) on delete no action on update cascade
);

CREATE TABLE Plays
(
  Club_ID INT NOT NULL,
  Match_ID INT NOT NULL,
  PRIMARY KEY (Club_ID, Match_ID),
  FOREIGN KEY (Club_ID) REFERENCES Football_Club(Club_ID) on delete no action on update cascade,
  FOREIGN KEY (Match_ID) REFERENCES FMatch(Match_ID) on delete No action on update cascade
);

CREATE TABLE Admin_USERS
(
USERNAME VARCHAR(50) NOT NULL,
PASS_WORD INT NOT NULL,
PRIMARY KEY (USERNAME),
unique (PASS_WORD)
);

CREATE TABLE S_USERS
(
USERNAME VARCHAR(50) NOT NULL,
PASS_WORD INT NOT NULL,
PRIMARY KEY (USERNAME),
unique (PASS_WORD)
);

CREATE TABLE C_USERS
(
USERNAME VARCHAR(50) NOT NULL,
PASS_WORD INT NOT NULL,
PRIMARY KEY (USERNAME),
unique (PASS_WORD)
);

CREATE TABLE Club_Admin_USERS
(
USERNAME VARCHAR(50) NOT NULL,
PASS_WORD INT NOT NULL,
PRIMARY KEY (USERNAME),
unique (PASS_WORD)
);

-----------inserting FMatch Foreign key---------------------------------------------------------------
alter table FMatch add foreign key (Stadium) references Stadium on delete set default on update no action 
alter table FMatch add foreign key (Home_Team) references Football_Club(Club_Name) ON DELETE no action on update no action
alter table FMatch add foreign key (Away_Team) references Football_Club(Club_Name) ON DELETE no action on update no action
alter table FMatch add foreign key (Referee_ID,season) references Referee(Referee_ID,Season) on delete set null on update cascade--handle by code to set a defualt referee

 -----------inserting TRANSFERE MARKET Foreign key---------------------------------------------------------------
 alter table Transfer_Market add foreign key (Season) references Tournament on delete no action on update no action 
 alter table Transfer_Market add foreign key (Player_ID,Season) references Football_Player(ID,Season) on delete no action on update cascade 
 alter table Transfer_Market add foreign key (TLeft) references Football_Club (Club_Name) on delete no action on update no action 
 alter table Transfer_Market add foreign key (TJoined) references Football_Club (Club_Name) on delete no action on update no action 

 -----------inserting TORNAMENT Foreign key---------------------------------------------------------------
 alter table Tournament add foreign key (Sponsor_name) references Sponsor (Sponsor_Name) on delete no action on update cascade 

 -----------inserting CLUB ID Foreign key---------------------------------------------------------------
 alter table Tournament_ClubID add foreign key (ClubID) references Football_Club (Club_ID) on delete no action on update cascade 

 -----------Inserting values into tables---------------------------------------------------------------

 insert into Tournament
 values 
 ('5000000$','2500000',6,null,1,'FINISHED'),
 ('5000000$','2500000',6,null,2,'INPROGRESS')
 ----------------------------------------------------------------
 insert into Tournament_Admin
 values
 ('GIANNI','INFANTINO',10,1),
 ('GIANNI','INFANTINO',10,2)

 ----------------------------------------------------------------
 insert into Admin_USERS
 values
 ('GIANNI',1234)

----------------------------------------------------------------
 insert into Football_Club
values
('$850M',100,1902,'Real_Madrid_FC','Madrid'),
('$700M',200,1899,'FC_Barcelona','Barcelona'),
('$650M',300,1900,'FC_Bayern_Munich','Munich'),
('$500M',400,1892,'Liverpool','Liverpool'),
('$200M',500,1907,'Al_Ahly_SC','Cairo'),
('$900M',600,1970,'Paris_Saint_Germain_FC','Paris')
-----------------------------------------------------------------
 insert into Football_Player 
 values
 ---REAL MADRID---
('TIBO','COURTOIS','Belgium',30,'$6.00m','Crucial',0 ,13 ,0 ,1 ,'$60.00m', 'GK',100,1),
('Daniel','CARVAJAL','Spain',30,'$6.00m','Crucial',4 ,15 ,3 ,2 ,'$10.00m', 'RB', 100,1),
('David','ALABA','Austria',30,'$7.00m','Crucial',5 ,4 ,2 ,3 ,'$80.00m', 'CB', 100,1),
('EDER','MILITAO','Brazil',24,'$5.00m','Crucial',1 ,3 ,0 ,4 ,'$80.00m', 'CB', 100,1),
('Ferland','Mendy','France',27,'$4.50m','Crucial',3 ,23 ,7 ,5 ,'$50.00m', 'LB', 100,1),
('Luis','Casimero','Brazil',30,'$4.50m','Crucial',5 ,14 ,3 ,6 ,'$40.00m','CDM',100,1),
('Luka','MODRIC','Croatia',37,'$8.50m','Crucial',10 ,19,15 ,7 ,'$50.00m', 'CM',100,1),
('Toni','Kroos','Germany',32,'$8.50m','Crucial',5 ,8 ,13 ,8 ,'$60.00m', 'CM', 100,1),
('Fedrecko','Valverde','Uruguay',23,'$10.50m','Crucial',6 ,23 ,4 ,9 ,'$90.00m','CM',100,1),
('Karim','Benzema','France',34,'$14.50m','Crucial',40 ,9 ,15 ,10 ,'$70.00m', 'ST', 100,1),
('Vinicius','Junior','Brazil',22,'$10.50m','Crucial',20 ,20 ,10 ,11 ,'$90.00m', 'LM' ,100,1),
('Marcelo','Junior','Brazil',33,'$5.50m','Important',4 ,12,7 ,12 ,'$20.00m','LB' ,100,1),
('Eduaordo','Camavinga','France',19,'$5.50m','Important',3 ,25 ,2 ,13 ,'$20.00m', 'CM',100,1),
('Nacho','Fernandez','spain',24,'$3.50m','Important',2 ,6 ,1 ,14 ,'$30.00m', 'CB',100,1),
('Eden','Hazard','Belgium',31,'$7.50m','Important',10 ,7 ,6 ,15 ,'$40.00m', 'LM',100,1),

---LIVERPOOL---
 ('Becker','Alisson','Brazil',30,'$6.00m','Crucial',0,1,0 ,16 ,'$60.00m', 'GK',400,1),
 ('Andrew','Robertson','Scotland',28,'$10.00m','Crucial',2,26,10,17 ,'$90.00m', 'LB',400,1),
 ('IBRAHIMA','KONATE','FRANCE',22,'$4.00m','IMPORTAT',0 ,5,1 ,18 ,'$40.00m', 'CB',400,1),
 ('VIRGIL','VANDIJK','NETHERLANDS',31,'$20.00m','Crucial',3 ,4,2 ,19 ,'$60.00m', 'CB',400,1),
 ('TRENT','ARNOLD','ENGLAND',23,'$11.00m','Crucial',5 ,66,15 ,20 ,'$100.00m', 'RB',400,1),
 ('THIAGO','ALCANATARA','SPAIN',29,'$8.00m','Crucial',4,6,11 ,21 ,'$60.00m', 'CM',400,1),
 ('JORDAN','HENDERSON','ENGLAND',31,'$6.00m','Crucial',0 ,14,3 ,22 ,'$60.00m', 'CDM',400,1),
 ('NABY','KEITA','GYUNEA',27,'$6.00m','IMPORTANT',3 ,8,2 ,23 ,'$50.00m', 'CM',400,1),
 ('SADIO','MANE','SENEGAL',29,'$12.00m','Crucial',15 ,10,9 ,24 ,'$100.00m', 'LW',400,1),
 ('DIOGO','JOTA','PORTUGAL',26,'$8.00m','Crucial',9 ,20,6 ,25 ,'$70.00m', 'ST',400,1),
 ('MOHAMED','SALAH','EGYPT',30,'$15.00m','Crucial',40 ,11,15 ,26 ,'$140.00m', 'RW',400,1),
 ('ROBERT','FIRMINIO','Brazil',30,'$7.00m','IMPORTANT',9 ,9,8 ,27 ,'$60.00m', 'ST',400,1),
 ('JAMES','MILNER','ENGLAND',36,'$4.00m','ROTATION',1 ,7,3 ,28 ,'$20.00m', 'CM',400,1),
 ('ALEX','CHAMBERLAIN','ENGLAND',30,'$6.00m','ROTATION',2 ,15,4 ,29 ,'$60.00m', 'GK',400,1),
 ('DIVOK','ORIGI','BELGIUM',27,'$5.00m','ROTATION',3 ,27,2 ,30,'$50.00m', 'ST',400,1),
 ---BAYERN MUNICH---
 ('Manuel','Neuer','Germany',36,'$10.00m','Crucial',0 ,1 ,0 ,31 ,'€60.00m', 'GK',300,1),
('dayot','upamecano','France',24,'$7.00m','Crucial',0 ,2 ,0 ,32 ,'€70.00m', 'CB',300,1),
('Lucas','Hernandez','France',26,'$5.00m','Crucial',0 ,21 ,5 ,33 ,'€40.00m', 'LB',300,1),
('Niklas','Sule','Germany',27,'$6.00m','Crucial',3 ,4 ,0 ,34 ,'€40.00m', 'CB',300,1),
('Alphonso','Davies','Canada',22,'$8.00m','Crucial',5 ,19 ,10 ,35 ,'€100.00m', 'LB',300,1),
('benjamin','pavard','France',26,'$7.00m','Crucial',5 ,5 ,7 ,36 ,'€45.00m', 'RB',300,1),
('jousha','kimmich','Germany',27,'$9.00m','Crucial',5 ,6 ,7 ,37 ,'€70.00m', 'CM',300,1),
('Leon','Goretzaka','Germany',27,'$7.00m','Crucial',8 ,8 ,10 ,38 ,'€50.00m', 'CM',300,1),
('corentin','tolliso','France',28,'$5.00m','Crucial',5 ,24 ,7 ,39 ,'€30.00m', 'CM',300,1),
('Jamal','Musiala','Germany',19,'$4.00m','Crucial',14 ,42 ,10 ,40 ,'€140.00m', 'CM',300,1),
('Leory','Sane','Germany',26,'$10.00m','Crucial',20 ,10 ,15 ,41 ,'€150.00m', 'LW',300,1),
('Serge','Gnabry','Germany',27,'$10.00m','Crucial',24 ,7 ,16 ,42 ,'€150.00m', 'RW',300,1),
('Thomas','Muller','Germany',33,'$10.00m','Crucial',20 ,25 ,14 ,43 ,'€70.00m', 'CF',300,1),
('Choupo','Mouting','Cameroon',33,'$4.00m','Important',10 ,13 ,7 ,44 ,'€25.00m', 'CF',300,1),
('Robert','Lewandouski','Poland',34,'$15.00m','Crucial',35 ,9 ,18 ,45 ,'€150.00m', 'CF',300,1),
 ---PARIS---
('Keylor','Navas','Costarica',34,'$6.00m','Crucial',0 ,1 ,0 ,46 ,'$40.00m', 'GK',600,1),
('Sergio','Ramos','Spain',34,'$5.00m','Crucial',4 ,4 ,1 ,47 ,'$20.00m', 'CB',600,1),
('Presnel','Kimpembe','France',24,'$6.00m','Crucial',3 ,3 ,1 ,48 ,'$40.00m', 'CB',600,1),
('Dani','Marquinhos','Brazil',30,'$9.00m','Crucial',6 ,5 ,2 ,49 ,'$30.00m', 'CB',600,1),
('Juan','Bernat','Spain',28,'$3.00m','Important',3 ,14 ,7 ,50 ,'$60.00m', 'LB',600,1),
('Marco','Veratti','Italy',29,'$7.00m','Crucial',4,6 ,4 ,51 ,'$50.00m', 'CM',600,1),
('Ander','Herrera','Spain',24,'$4.00m','Crucial',6 ,21 ,7 ,52 ,'$40.00m', 'CM',600,1),
('Adres','Gueye','Senegal',29,'$2.50m','Crucial',3 ,27 ,2 ,53 ,'$20.00m', 'CM',600,1),
('Angel','Di Maria','Argentina',31,'$10.00m','Crucial',12 ,11 ,10 ,54 ,'$60.00m', 'RM',600,1),
('Neymar','Junior','Brazil',31,'$14.00m','Crucial',25 ,10 ,14 ,55 ,'$150.00m', 'LM',600,1),
('Kylian','Mbappe','France',23,'$13.50m','Crucial',24 ,7 ,15 ,56 ,'$180.00m', 'ST',600,1),
('Lionel','Messi','Argentina',35,'$20.00m','Crucial',48 ,30 ,25 ,57 ,'$170.00m', 'RM',600,1),
('Pablo','Sarabia','Spain',26,'$4.00m','Important',6 ,17 ,4 ,58 ,'$40.00m', 'CM',600,1),
('Alessandro','Florenzi','Italy',32,'$6.00m','Important',2 ,24 ,7 ,59 ,'$25.00m', 'RB',600,1),
('Abdou','Diallo','Senegal',24,'$4.00m','Important',1 ,22 ,9 ,60 ,'$15.00m', 'LB',600,1),

 ---AL AHLY---
 ('MOHAMED','SELHENAWY','EGYPT',32,'$500K','Crucial',0 ,1,0 ,61 ,'$2.00m', 'GK',500,1),
 ('BADR','BANOUN','MOROCCO',28,'$400K','Crucial',3 ,13,1 ,62 ,'$1.50m', 'CB',500,1),
 ('AYMAN','ASHRAF','EGYPT',31,'$200K','Crucial',1 ,12,3 ,63 ,'$1.00m', 'CB',500,1),
 ('ALI','MAALOUL','TUNISIA',32,'$700K','Crucial',10 ,21,9 ,64 ,'$2.50m', 'LB',500,1),
 ('AKRAM','TAWFIK','EGYPT',25,'$750K','IMPORTANT',1 ,25,2 ,65 ,'$500K', 'RB',500,1),
 ('HAMDI','FATHI','EGYPT',27,'$800K','Crucial',5 ,8,4 ,66 ,'$500K', 'CDM',500,1),
 ('AMR','ELSOLAIA','EGYPT',31,'$600K','Crucial',4 ,17,3 ,67 ,'$300K', 'CM',500,1),
 ('ALIOU','DIENG','EGYPT',24,'$900K','Crucial',3 ,15,4 ,68 ,'$1.00m', 'CDM',500,1),
 ('MGADY','AFSHA','EGYPT',25,'$900K','Crucial',8 ,19,10 ,69 ,'$900K', 'CM',500,1),
 ('MOHAMED','SHERIF','EGYPT',25,'$800K','IMPORTANT',14 ,10,4 ,70,'$700K', 'ST',500,1),
 ('PERCY','TAU','SOUTHAFRICA',28,'$1.30m','Crucial',9 ,23,4 ,71 ,'$4.50m', 'ST',500,1),
 ('LUIS','MIUISSONE','MOZAMBIQUE',26,'$1.00m','Crucial',5 ,29,4 ,72 ,'$2.50m', 'LW',500,1),
 ('HUSSEIN','ELSHAHT','EGYPT',27,'$900K','ROTATION',5 ,14,4 ,73 ,'$900K', 'RW',500,1),
 ('TAHER','MOHAMED','EGYPT',24,'$600K','ROTATION',4 ,27,4 ,74 ,'$300K', 'LW',500,1),
 ('AMMAR','HAMDY','EGYPT',22,'$200K','ROTATION',5 ,38,1,75 ,'$400K', 'CM',500,1),

  ---BARCELONA---
('Marc','TerStegen','Germany',30,'$10.00m','Crucial',0 ,1 ,0 ,76 ,'$50.00m', 'GK',200,1),
('Ronald','Araujo','Uruaugy',22,'$2.00m','Important',0 ,2 ,0 ,77 ,'$30.00m', 'CB',200,1),
('Eric','Garcia','Spain',20,'$3.00m','Crucial',0 ,24 ,0 ,78 ,'$35.00m', 'CB',200,1),
('Gerard','Pique','Spain',34,'$5.00m','Crucial',3 ,3 ,0 ,79 ,'$10.00m', 'CB',200,1),
('oscar','mingueza','Spain',22,'$2.00m','Important',2 ,22 ,2 ,80 ,'$15.00m', 'RB',200,1),
('Jordi','Alba','Spain',33,'$5.00m','Crucial',5 ,18 ,5 ,81 ,'$20.00m', 'LB',200,1),
('Sergio','Busquets','Spain',33,'$4.00m','Crucial',2 ,5 ,0 ,82 ,'$15.00m', 'CM',200,1),
('Sergino','Dest','America',22,'$3.00m','Crucial',4 ,2 ,5 ,83 ,'$15.00m', 'LB',200,1),
('Daniel','Alves','Brazil',38,'$2.00m','Important',0 ,8 ,0 ,84 ,'$5.00m', 'LB',200,1),
('Frankie','Dejong','Netherlands',24,'$5.00m','Crucial',10 ,21 ,10 ,85 ,'$80.00m', 'CM',200,1),
('Riqui','puig','Spain',22,'$2.00m','Crucial',6 ,6 ,5 ,86 ,'$45.00m', 'CM',200,1),
('Ansu','Fati','Spain',19,'$8.00m','Crucial',15 ,10 ,10 ,87 ,'$140.00m', 'LW',200,1),
('Ousmane','Dembele','France',24,'$6.00m','Crucial',10 ,7 ,10 ,88 ,'$70.00m', 'RW',200,1),
('Memphis','Depay','Netherlands',27,'$6.00m','Cruical',15 ,9 ,7 ,89 ,'$90.00m', 'CF',200,1),
('Martin','Braithwaite','Denmark',31,'$4.00m','Important',7 ,12 ,5 ,90 ,'$10.00m', 'CF',200,1),


--------------SEASON 2--------------------------

---REAL MADRID---
('TIBO','COURTOIS','Belgium',30,'$6.00m','Crucial',0 ,13 ,0 ,1 ,'$60.00m', 'GK',100,2),
('Daniel','CARVAJAL','Spain',30,'$6.00m','Crucial',0 ,15 ,0 ,2 ,'$10.00m', 'RB', 100,2),
('David','ALABA','Austria',30,'$7.00m','Crucial',0 ,4 ,0 ,3 ,'$80.00m', 'CB', 100,2),
('EDER','MILITAO','Brazil',24,'$5.00m','Crucial',0 ,3 ,0 ,4 ,'$80.00m', 'CB', 100,2),
('Ferland','Mendy','France',27,'$4.50m','Crucial',0 ,23 ,0 ,5 ,'$50.00m', 'LB', 100,2),
('Luis','Casimero','Brazil',30,'$4.50m','Crucial',0 ,14 ,0 ,6 ,'$40.00m','CDM',100,2),
('Luka','MODRIC','Croatia',37,'$8.50m','Crucial',0 ,19,0 ,7 ,'$50.00m', 'CM',100,2),
('Toni','Kroos','Germany',32,'$8.50m','Crucial',2 ,8 ,1 ,8 ,'$60.00m', 'CM', 100,2),
('Fedrecko','Valverde','Uruguay',24,'$10.50m','Crucial',0 ,23 ,0 ,9 ,'$90.00m','CM',100,2),
('Karim','Benzema','France',34,'$14.50m','Crucial',5 ,9 ,2 ,10 ,'$70.00m', 'ST', 100,2),
('Vinicius','Junior','Brazil',22,'$10.50m','Crucial',3 ,20 ,3 ,11 ,'$90.00m', 'LM' ,100,2),
('Marcelo','Junior','Brazil',34,'$5.50m','Important',0 ,12,0 ,12 ,'$20.00m','LB' ,100,2),
('Eduaordo','Camavinga','France',20,'$5.50m','Important',0 ,25 ,0 ,13 ,'$20.00m', 'CM',100,2),
('Nacho','Fernandez','spain',25,'$3.50m','Important',0 ,6 ,0 ,14 ,'$30.00m', 'CB',100,2),
('Eden','Hazard','Belgium',31,'$7.50m','Important',0 ,7 ,0 ,15 ,'$40.00m', 'LM',100,2),

---LIVERPOOL---
 ('Becker','Alisson','Brazil',30,'$6.00m','Crucial',0,1,0 ,16 ,'$60.00m', 'GK',400,2),
 ('Andrew','Robertson','Scotland',28,'$10.00m','Crucial',0,26,2,17 ,'$90.00m', 'LB',400,2),
 ('IBRAHIMA','KONATE','FRANCE',23,'$4.00m','IMPORTAT',0 ,5,0 ,18 ,'$40.00m', 'CB',400,2),
 ('VIRGIL','VANDIJK','NETHERLANDS',31,'$20.00m','Crucial',0 ,4,0 ,19 ,'$60.00m', 'CB',400,2),
 ('TRENT','ARNOLD','ENGLAND',24,'$11.00m','Crucial',0 ,66,0 ,20 ,'$100.00m', 'RB',400,2),
 ('THIAGO','ALCANATARA','SPAIN',30,'$8.00m','Crucial',0,6,0 ,21 ,'$60.00m', 'CM',400,2),
 ('JORDAN','HENDERSON','ENGLAND',31,'$6.00m','Crucial',0 ,14,0 ,22 ,'$60.00m', 'CDM',400,2),
 ('NABY','KEITA','GYUNEA',27,'$6.00m','IMPORTANT',0 ,8,0 ,23 ,'$50.00m', 'CM',400,2),
 ('SADIO','MANE','SENEGAL',30,'$12.00m','Crucial',3 ,10,0 ,24 ,'$100.00m', 'LW',400,2),
 ('DIOGO','JOTA','PORTUGAL',26,'$8.00m','Crucial',2 ,20,2 ,25 ,'$70.00m', 'ST',400,2),
 ('MOHAMED','SALAH','EGYPT',30,'$15.00m','Crucial',6 ,11,1 ,26 ,'$140.00m', 'RW',400,2),
 ('ROBERT','FIRMINIO','Brazil',30,'$7.00m','IMPORTANT',2 ,9,0 ,27 ,'$60.00m', 'ST',400,2),
 ('JAMES','MILNER','ENGLAND',35,'$4.00m','ROTATION',0 ,7,0 ,28 ,'$20.00m', 'CM',400,2),
 ('ALEX','CHAMBERLAIN','ENGLAND',29,'$6.00m','ROTATION',0 ,15,0 ,29 ,'$60.00m', 'GK',400,2),
 ('DIVOK','ORIGI','BELGIUM',26,'$5.00m','ROTATION',0 ,27,0 ,30,'$50.00m', 'ST',400,2),
 ---BAYERN MUNICH---
 ('Manuel','Neuer','Germany',35,'$10.00m','Crucial',0 ,1 ,0 ,31 ,'€60.00m', 'GK',300,2),
('dayot','upamecano','France',23,'$7.00m','Crucial',0 ,2 ,0 ,32 ,'€70.00m', 'CB',300,2),
('Lucas','Hernandez','France',25,'$5.00m','Crucial',0 ,21 ,0 ,33 ,'€40.00m', 'LB',300,2),
('Niklas','Sule','Germany',26,'$6.00m','Crucial',0 ,4 ,0 ,34 ,'€40.00m', 'CB',300,2),
('Alphonso','Davies','Canada',21,'$8.00m','Crucial',0 ,19 ,0 ,35 ,'€100.00m', 'LB',300,2),
('benjamin','pavard','France',25,'$7.00m','Crucial',0 ,5 ,0 ,36 ,'€45.00m', 'RB',300,2),
('jousha','kimmich','Germany',26,'$9.00m','Crucial',0 ,6 ,0 ,37 ,'€70.00m', 'CM',300,2),
('Leon','Goretzaka','Germany',26,'$7.00m','Crucial',0 ,8 ,0 ,38 ,'€50.00m', 'CM',300,2),
('corentin','tolliso','France',27,'$5.00m','Crucial',0 ,24 ,0 ,39 ,'€30.00m', 'CM',300,2),
('Jamal','Musiala','Germany',18,'$4.00m','Crucial',0 ,42 ,0 ,40 ,'€140.00m', 'CM',300,2),
('Leory','Sane','Germany',25,'$10.00m','Crucial',4 ,10 ,0 ,41 ,'€150.00m', 'LW',300,2),
('Serge','Gnabry','Germany',26,'$10.00m','Crucial',1 ,7 ,0 ,42 ,'€150.00m', 'RW',300,2),
('Thomas','Muller','Germany',32,'$10.00m','Crucial',1 ,25 ,0 ,43 ,'€70.00m', 'CF',300,2),
('Choupo','Mouting','Cameroon',32,'$4.00m','Important',1 ,13 ,0 ,44 ,'€25.00m', 'CF',300,2),
('Robert','Lewandouski','Poland',33,'$15.00m','Crucial',4 ,9 ,2 ,45 ,'€150.00m', 'CF',300,2),
 ---PARIS---
('Keylor','Navas','Costarica',33,'$6.00m','Crucial',0 ,1 ,0 ,46 ,'$40.00m', 'GK',600,2),
('Sergio','Ramos','Spain',33,'$5.00m','Crucial',0 ,4 ,0 ,47 ,'$20.00m', 'CB',600,2),
('Presnel','Kimpembe','France',23,'$6.00m','Crucial',0 ,3 ,1 ,48 ,'$40.00m', 'CB',600,2),
('Dani','Marquinhos','Brazil',29,'$9.00m','Crucial',0 ,5 ,0 ,49 ,'$30.00m', 'CB',600,2),
('Juan','Bernat','Spain',27,'$3.00m','Important',0 ,14 ,0 ,50 ,'$60.00m', 'LB',600,2),
('Marco','Veratti','Italy',28,'$7.00m','Crucial',0,6 ,0 ,51 ,'$50.00m', 'CM',600,2),
('Ander','Herrera','Spain',24,'$4.00m','Crucial',0 ,21 ,0 ,52 ,'$40.00m', 'CM',600,2),
('Adres','Gueye','Senegal',29,'$2.50m','Crucial',0 ,27 ,0 ,53 ,'$20.00m', 'CM',600,2),
('Angel','Di Maria','Argentina',31,'$10.00m','Crucial',2 ,11 ,0 ,54 ,'$60.00m', 'RM',600,2),
('Neymar','Junior','Brazil',30,'$14.00m','Crucial',3 ,10 ,3 ,55 ,'$150.00m', 'LM',600,2),
('Kylian','Mbappe','France',22,'$13.50m','Crucial',0 ,7 ,0 ,56 ,'$180.00m', 'ST',600,2),
('Lionel','Messi','Argentina',34,'$20.00m','Crucial',0 ,30 ,0 ,57 ,'$170.00m', 'RM',600,2),
('Pablo','Sarabia','Spain',26,'$4.00m','Important',0 ,17 ,0 ,58 ,'$40.00m', 'CM',600,2),
('Alessandro','Florenzi','Italy',32,'$6.00m','Important',3 ,24 ,1 ,59 ,'$25.00m', 'RB',600,2),
('Abdou','Diallo','Senegal',24,'$4.00m','Important',0 ,22 ,0 ,60 ,'$15.00m', 'LB',600,2),

 ---AL AHLY---
 ('MOHAMED','SELHENAWY','EGYPT',31,'$500K','Crucial',0 ,1,0 ,61 ,'$2.00m', 'GK',500,2),
 ('BADR','BANOUN','MOROCCO',28,'$400K','Crucial',0 ,13,0 ,62 ,'$1.50m', 'CB',500,2),
 ('AYMAN','ASHRAF','EGYPT',31,'$200K','Crucial',1 ,12,1 ,63 ,'$1.00m', 'CB',500,2),
 ('ALI','MAALOUL','TUNISIA',31,'$700K','Crucial',1 ,21,0 ,64 ,'$2.50m', 'LB',500,2),
 ('AKRAM','TAWFIK','EGYPT',24,'$750K','IMPORTANT',0 ,25,0 ,65 ,'$500K', 'RB',500,2),
 ('HAMDI','FATHI','EGYPT',27,'$800K','Crucial',0 ,8,0 ,66 ,'$500K', 'CDM',500,2),
 ('AMR','ELSOLAIA','EGYPT',31,'$600K','Crucial',0 ,17,0 ,67 ,'$300K', 'CM',500,2),
 ('ALIOU','DIENG','EGYPT',24,'$900K','Crucial',0 ,15,0 ,68 ,'$1.00m', 'CDM',500,2),
 ('MGADY','AFSHA','EGYPT',25,'$900K','Crucial',0 ,19,0 ,69 ,'$900K', 'CM',500,2),
 ('MOHAMED','SHERIF','EGYPT',25,'$800K','IMPORTANT',0 ,10,0 ,70,'$700K', 'ST',500,2),
 ('PERCY','TAU','SOUTHAFRICA',27,'$1.30m','Crucial',0 ,23,0 ,71 ,'$4.50m', 'ST',500,2),
 ('LUIS','MIUISSONE','MOZAMBIQUE',26,'$1.00m','Crucial',0 ,29,0 ,72 ,'$2.50m', 'LW',500,2),
 ('HUSSEIN','ELSHAHT','EGYPT',27,'$900K','ROTATION',0 ,14,0 ,73 ,'$900K', 'RW',500,2),
 ('TAHER','MOHAMED','EGYPT',24,'$600K','ROTATION',0 ,27,0 ,74 ,'$300K', 'LW',500,2),
 ('AMMAR','HAMDY','EGYPT',22,'$200K','ROTATION',3 ,38,1,75 ,'$400K', 'CM',500,2),

  ---BARCELONA---
('Marc','TerStegen','Germany',29,'$10.00m','Crucial',0 ,1 ,0 ,76 ,'$50.00m', 'GK',200,2),
('Ronald','Araujo','Uruaugy',22,'$2.00m','Important',0 ,2 ,0 ,77 ,'$30.00m', 'CB',200,2),
('Eric','Garcia','Spain',20,'$3.00m','Crucial',0 ,24 ,0 ,78 ,'$35.00m', 'CB',200,2),
('Gerard','Pique','Spain',34,'$5.00m','Crucial',3 ,3 ,0 ,79 ,'$10.00m', 'CB',200,2),
('oscar','mingueza','Spain',22,'$2.00m','Important',0 ,22 ,0 ,80 ,'$15.00m', 'RB',200,2),
('Jordi','Alba','Spain',33,'$5.00m','Crucial',0 ,18 ,0 ,81 ,'$20.00m', 'LB',200,2),
('Sergio','Busquets','Spain',33,'$4.00m','Crucial',2 ,5 ,0 ,82 ,'$15.00m', 'CM',200,2),
('Sergino','Dest','America',22,'$3.00m','Crucial',1 ,2 ,0 ,83 ,'$15.00m', 'LB',200,2),
('Daniel','Alves','Brazil',39,'$2.00m','Important',0 ,8 ,0 ,84 ,'$5.00m', 'LB',200,2),
('Frankie','Dejong','Netherlands',24,'$5.00m','Crucial',2 ,21 ,0 ,85 ,'$80.00m', 'CM',200,2),
('Riqui','puig','Spain',22,'$2.00m','Crucial',0 ,6 ,0 ,86 ,'$45.00m', 'CM',200,2),
('Ansu','Fati','Spain',19,'$8.00m','Crucial',0 ,10 ,0 ,87 ,'$140.00m', 'LW',200,2),
('Ousmane','Dembele','France',24,'$6.00m','Crucial',0 ,7 ,0 ,88 ,'$70.00m', 'RW',200,2),
('Memphis','Depay','Netherlands',27,'$6.00m','Cruical',2 ,9 ,0 ,89 ,'$90.00m', 'CF',200,2),
('Martin','Braithwaite','Denmark',30,'$4.00m','Important',0 ,12 ,0 ,90 ,'$10.00m', 'CF',200,2)
-----------------------------------------------------------------
insert into Club_Admin
 values 
 ('Florentino','Perez',10,100),
 ('JOAN','LAPORTE',20,200),
 ('HERBERT','HAINER',30,300),
 ('TOM','WERNER',40,400),
 ('MAHMOUD','ELKHATEEB',50,500),
 ('NASSER','ALKHALIFIE',60,600)

-----------------------------------------------------------------
insert into Stadium
values
(77000,'Santiago','Madrid',1902,100),
(89000,'CampNou','Barcelona',1899,200),
(60000,'AlianzArena','Munich',1900,300),
(65000,'Anfield','Liverpool',1901,400),
(25000,'Elsalam','Cairo',1907,500),
(50000,'ParcDePrince','Paris',1970,600)
------------------------------------------------------------------
INSERT INTO Referee
VALUES
(24,3,5,'Martin','Atkinson',1,1),
(20,5,7,'Andre','Marriner',2,1),
(19,2,3,'Antonio','Mateu',3,1),
(15,4,2,'paolo','Valeri',4,1),
(20,2,5,'Mohamed','Hanafy',5,1),

(4,0,0,'Martin','Atkinson',1,2),
(2,0,2,'Andre','Marriner',2,2),
(1,0,1,'Antonio','Mateu',3,2),
(3,1,0,'paolo','Valeri',4,2),
(2,0,0,'Mohamed','Hanafy',5,2)

------------------------------------------------------------------
INSERT INTO Sponsor
VALUES
('NIVEA',1,1),
('ADIDAS',2,1),
('NIKE',3,1),
('PUMA',4,1),
('NB',5,1),
('QARAR_AIRWAYS',6,1),
('FLY_EMIRATES',7,1),
('CHEVROLET',8,1),
('VODAFONE',9,1),
('SAMSUNG',10,1),

('cocacola',11,2),
('shell',12,2),
('wee',13,2)

------------------------------------------------------------------
INSERT INTO Coach
VALUES
('$3.00m',62,1,'Carlos','Ancelotti','Italy',100 ,1),
('$2.00m',41,2,'Xavi','Hernandes','Spain',200 ,1),
('$2.00m',45,3,'Julian',' Nagelsmann','Germany',300 ,1),
('$4.00m',54,4,'Jürgen',' klopp','Germany',400 ,1),
('$1.00m',56,5,'Pitso',' Mosimane','South Africa',500 ,1),
('$3.00m',55,6,'mauricio',' pochettino','Argentina',600 ,1),

('$3.00m',63,1,'Carlos','Ancelotti','Italy',100 ,2),
('$2.00m',42,2,'Xavi','Hernandes','Spain',200 ,2),
('$2.00m',46,3,'Julian',' Nagelsmann','Germany',300 ,2),
('$4.00m',55,4,'Jürgen',' klopp','Germany',400 ,2),
('$1.00m',57,5,'Pitso',' Mosimane','South Africa',500 ,2),
('$3.00m',56,6,'mauricio',' pochettino','Argentina',600 ,2)

-------------------------------------------------------------------
INSERT INTO FMatch
VALUES
('Real_Madrid_FC',1,'Liverpool','Santiago','2021-12-16',1,1),
('Liverpool',2,'Paris_Saint_Germain_FC','Anfield','2021-12-30',2,1),


('Real_Madrid_FC',21,'Liverpool','Santiago','2021-12-16',1,2),
('Liverpool',22,'Real_Madrid_FC','Anfield','2021-12-30',2,2)


---------------------------------------------------------------------------
INSERT INTO HAS
VALUES
(2017,NULL,200,6),
(2019,NULL,300,2),
(2018,NULL,400,5),
(2018,NULL,100,5)
-----------------------------------------------------------------------------
INSERT INTO Plays
VALUES
(100,1),
(100,21),
(100,22)
----------------------------------------------------------------------------------
INSERT INTO Standings
VALUES 
(70,8,1,1,7,10,25,'Liverpool',1),
(70,7,2,1,7,10,23,'Paris_Saint_Germain_FC',1),
(60,9,0,1,9,10,28,'Real_Madrid_FC',1),
(50,5,2,3,5,10,18,'Al_Ahly_SC',1),
(65,7,0,3,7,10,24,'FC_Bayern_Munich',1),
(55,6,2,2,6,10,20,'FC_Barcelona',1),

(9,2,0,0,2,2,6,'Liverpool',2),
(8,3,0,0,2,1,6,'Paris_Saint_Germain_FC',2),
(10,2,0,0,3,3,9,'Real_Madrid_FC',2),
(7,5,1,0,1,1,4,'Al_Ahly_SC',2),
(11,7,1,0,1,2,4,'FC_Bayern_Munich',2),
(5,6,1,1,0,2,3,'FC_Barcelona',2)
-----------------------------------------------------------------------------------
INSERT INTO Tickets_Availability
VALUES
('AVALIABLE',2),
('UNAVALIABLE',1),
('AVALIABLE',22),
('UNAVALIABLE',21)
---------------------------------------------------------------------------------------
INSERT INTO Tournament_ClubID
VALUES
(100,1),
(200,1),
(300,1),
(400,1),
(500,1),
(600,1),
(100,2),
(200,2),
(300,2),
(400,2),
(500,2),
(600,2)
---------------------------------------------------------------------------------------
INSERT INTO Transfer_Market
VALUES
(12,3,1,'FC_Bayern_Munich','Real_Madrid_FC',7000067,'2021-09-13'),
(14,36,1,'Real_Madrid_FC','FC_Bayern_Munich',6574447,'2021-09-11'),
(15,37,1,'Real_Madrid_FC','FC_Bayern_Munich',1076409,'2021-09-16'),
(19,57,1,'Liverpool','Paris_Saint_Germain_FC',438889,'2021-09-17'),
(11,20,1,'Paris_Saint_Germain_FC','Liverpool',267729,'2021-09-16'),
(09,88,1,'Paris_Saint_Germain_FC','FC_Barcelona',432111,'2021-09-20'),
(08,72,1,'FC_Bayern_Munich','Al_Ahly_SC',1230000,'2021-09-24'),

(30,6,2,'Paris_Saint_Germain_FC','Real_Madrid_FC',5000000,'2021-09-13'),
(31,38,2,'Real_Madrid_FC','FC_Bayern_Munich',6000000,'2021-09-11'),
(32,33,2,'FC_Bayern_Munich','FC_Bayern_Munich',8000000,'2021-09-16'),
(33,54,2,'Al_Ahly_SC','Paris_Saint_Germain_FC',7000000,'2021-09-17'),
(34,21,2,'Paris_Saint_Germain_FC','Liverpool',3987777,'2021-09-16'),
(35,86,2,'FC_Bayern_Munich','FC_Barcelona',1000000,'2021-09-20'),
(45,70,2,'Real_Madrid_FC','Al_Ahly_SC',1230000,'2021-09-24')
------------------------------------------------------------------------------------------
INSERT INTO C_USERS
VALUES
('Ancelotti',123451),
('Xavi',123452),
('Julian',123453),
('Pitso',123454),
('pochettino',123455),
('klopp',123456)
-----------------------------------------------------------------------------------------------------
INSERT INTO Club_Admin_USERS
VALUES
('Perez',123451),
('LAPORTE',123452),
('HAINER',123453),
('WERNER',123454),
('ELKHATEEB',123455),
('ALKHALIFIE',123456)
-------------------------------------------------------------------------------------------------------
INSERT INTO S_USERS
VALUES
('AMIN',000000)


-----------UPDATE values in tables---------------------------------------------------------------

update Tournament set Sponsor_name = 'FLY_EMIRATES'	where Season = 1
update Tournament set Sponsor_name = 'SAMSUNG' where Season = 2

----------------------------------------------------COMPLEX PROC-----------------------------------------------
USE SuperLeague
GO
--------FIRST----------
CREATE PROCEDURE SELECTTRANS @SEAS int 
AS
BEGIN
SELECT *
FROM Transfer_Market 
WHERE Season=@SEAS
ORDER BY TDate
END 
GO

--EXEC SELECTTRANS 1;
--GO

--------------SECOND-----------------
CREATE PROCEDURE  SELECTSCHED @SEAS int 
AS
BEGIN
SELECT *
FROM FMatch
WHERE season=@SEAS
ORDER BY MDATE
END 
GO

--EXEC SELECTSCHED 1;
--GO

--------------THIRD-------------------
CREATE PROCEDURE SELECTSTAND @SEAS int 
AS
BEGIN 
SELECT *
FROM Standings 
WHERE Season=@SEAS
ORDER BY Points DESC
END 
GO

--EXEC SELECTSTAND 1
--GO


----------FOURTH---------
CREATE PROCEDURE SELECTBESTPLAYER @SEAS int 
AS
BEGIN 
SELECT FNAME,LNAME,GOALS,Assists
FROM Football_Player 
WHERE SEASON=@SEAS AND GOALS=(SELECT MAX(GOALS)FROM Football_Player WHERE Season=@SEAS)  
END 
GO
--EXEC SELECTBESTPLAYER 1
--GO


------------FIFTH---------
CREATE PROCEDURE SELECTOLDESTPLAYER @SEAS int 
AS
BEGIN 
SELECT FNAME,LNAME,AGE
FROM Football_Player
WHERE SEASON=@SEAS AND AGE=(SELECT MAX(AGE)FROM Football_Player WHERE Season=@SEAS)
END 
GO


-----------LOGIN------------
--CREATE PROCEDURE RETUSER @pass int ,@OUT varchar(50) OUTPUT
--IF(SELECT PASS_WORD
--FROM Club_Admin_USERS
--WHERE PASS_WORD=@pass) IS NULL
--@OUT= 'NOT FOUND'
--else 
--@OUT=USERNAME
--GO
--DECLARE @OUT varchar(50)

--EXEC RETUSER 123451,@OUT
--SELECT @OUT
--GO
--EXEC SELECTOLDESTPLAYER 1
--GO

-------TO DROP PROC--------
--DROP PROC RETUSER
--GO


 





 

