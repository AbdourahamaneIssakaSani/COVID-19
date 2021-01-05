CREATE TABLE individu (
identifiant varchar(10) PRIMARY KEY NOT NULL,
nom varchar(20),
prenom varchar(20),
age int ,
sexe varchar(7),
nationalite varchar(30),
residence varchar(30),
date_voyage date,
autre_details text
);

CREATE TABLE depistage (
id int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
nom_test varchar(100),
date_test date,
positif int,
id_individu varchar(10),

CONSTRAINT FK_DepistageIndividu FOREIGN KEY(id_individu)
REFERENCES individu(identifiant)
);

CREATE TABLE lieu (
id int PRIMARY KEY NOT NULL IDENTITY,
coordonnees varchar(100),
date_lieu date,
heure time
);

CREATE TABLE codeQR (
id int PRIMARY KEY NOT NULL,
couleur varchar(7),
date_emission date,
details text,
id_depistage int NULL,
id_lieu int NULL,

CONSTRAINT FK_codeQRDepistage FOREIGN KEY(id_depistage)
REFERENCES depistage(id),

CONSTRAINT FK_CodeQRLieu FOREIGN KEY(id_lieu)
REFERENCES lieu(id)
);

CREATE TABLE consultationenligne (
id int PRIMARY KEY NOT NULL IDENTITY,
date_consultation date,
rapport text
);

CREATE TABLE traitement (
id int PRIMARY KEY NOT NULL IDENTITY,
date_traitement date,
details text,
est_vaccine int,
id_code int NULL,
id_consultation int NULL,

CONSTRAINT FK_TraitementCodeQR FOREIGN KEY (id_code)
REFERENCES codeQR(id),

CONSTRAINT FK_TraitementConsultation FOREIGN KEY (id_consultation)
REFERENCES consultationenligne(id)
);
