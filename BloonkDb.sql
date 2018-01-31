CREATE TABLE TipReferenca
(
	Id INT NOT NULL PRIMARY KEY,
	Naziv VARCHAR(50) NOT NULL,
	Aktivnost SMALLINT NOT NULL
);

INSERT INTO TipReferenca VALUES(1, 'Krvna grupa', 1);
INSERT INTO TipReferenca VALUES(2, 'Spol donora', 1);

CREATE TABLE Referenca
(
	ID INT NOT NULL PRIMARY KEY,
	TipReferencaID INT NOT NULL FOREIGN KEY REFERENCES TipReferenca(ID),
	Naziv VARCHAR(50) NOT NULL,
);


INSERT INTO Referenca VALUES(1,1, 'A +'); 
INSERT INTO Referenca VALUES(2,1, 'A -');
INSERT INTO Referenca VALUES(3,1, 'B +');
INSERT INTO Referenca VALUES(4,1, 'B -');
INSERT INTO Referenca VALUES(5,1, 'AB +');
INSERT INTO Referenca VALUES(6,1, 'AB -');
INSERT INTO Referenca VALUES(7,1, '0 +');
INSERT INTO Referenca VALUES(8,1, '0 -');
INSERT INTO Referenca VALUES(9,2, 'Muško');
INSERT INTO Referenca VALUES(10,2, 'Žensko');

CREATE TABLE Grad 
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	PostanskiBroj VARCHAR(15) NOT NULL,
	Naziv VARCHAR(100) NOT NULL
);

SELECT * FROM Grad
SELECT * FROM Referenca
INSERT INTO Grad VALUES ('10000', 'Zagreb');
INSERT INTO Grad VALUES ('51000', 'Rijeka');
INSERT INTO Grad VALUES ('52100', 'Pula');
INSERT INTO Grad VALUES ('21000', 'Split');
INSERT INTO Grad VALUES ('31000', 'Osijek');

CREATE TABLE DONOR 
(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Ime VARCHAR(50) NOT NULL,
	Prezime VARCHAR(50) NOT NULL,
	Oib VARCHAR(11) NOT NULL,
	RodjenDatum DATE NOT NULL,
	GradId INT NOT NULL FOREIGN KEY REFERENCES Grad(ID),
	Spol INT NOT NULL FOREIGN KEY REFERENCES Referenca(ID),
	KrvaGrupa INT NOT NULL FOREIGN KEY REFERENCES Referenca(ID),
	KontaktBroj VARCHAR(30),
	AktivanDonor BIT NOT NULL,
	DatumInsert DATETIME NULL,
	DatumUpdate DATETIME NULL
) 

ALTER TABLE Donor ADD UNIQUE (Oib)

DECLARE @InsertDatum DATETIME = GETDATE()
INSERT INTO DONOR VALUES('Hrvoje', 'Horvat', '00000000001', '01.01.1990', 1, 9,  1, '098 1530 0000', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Ivan',   'Horvat', '00000000002', '01.01.1990', 1, 9, 1, '098 1530 0001', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Lucija', 'Horvat', '00000000003', '01.01.1991', 1, 10, 2, '098 1530 0002', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Ivana',  'Ivanic', '00000000004', '01.01.1991', 1, 10, 2, '098 1530 0003', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Lucia',  'Luèiæ', '00000000005',  '01.01.1990', 2, 10, 3, '098 1530 0004', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Petra',  'Petroviæ', '00000000006', '01.01.1990', 3, 10, 3, '098 1530 0005', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Nikolina','Horvat', '00000000007', '01.01.1990', 3, 10, 4, '098 1530 0006', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Marija', 'Stipetiæ', '00000000008', '01.01.1990', 5, 10, 4, '098 1530 0007', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Margareta', 'Orliæ', '00000000009', '01.01.1990', 5, 10, 5, '098 1530 0008', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Miroslava', 'Miriæ', '00000000010', '01.01.1990', 4, 10, 5, '098 1530 0009', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Iva', 'Iviæ', '00000000011', '01.01.1990', 4, 10, 6, '098 1530 00010', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Hrvoje', 'Petriæ', '00000000131', '01.01.1990', 4, 9, 4, '098 1530 0011', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Marko', 'Horvat', '00000000012', '01.01.1990', 3, 9, 7, '098 1530 0012', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Ivan', 'Ivaniæ', '00000000013', '01.01.1990', 2, 9, 7, '098 1530 0013', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Filip', 'Luèiæ', '00000000014', '01.01.1990', 1, 9, 8, '098 1530 0014', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Hrvoje', 'Crnkoviæ', '00000000015', '01.01.1990', 5, 9, 8, '098 1530 0015', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Antun', 'Ljekarski', '00000000016', '01.01.1990', 2, 9, 9, '098 1530 0016', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Petar', 'Crni', '00000000017', '01.01.1990', 3, 9, 9, '098 1530 0017', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Ornela', 'Devescovi', '00000000018', '01.01.1990', 3, 10, 1, '098 1530 0018', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Ondina', 'Ivaniè', '00000000019', '01.01.1990', 4, 10, 1, '098 1530 0019', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Željka', 'Horvat', '00000000020', '01.01.1990', 4, 10, 1, '098 1530 0020', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Martina', 'Martinèiæ', '00000000021', '01.01.1990', 5, 10, 2, '098 1530 0021', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Bianka', 'Bijeliæ', '00000000022', '01.01.1990', 5, 10, 2, '098 1530 0022', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Olivio', 'Horvat', '00000000023', '01.01.1990', 2, 9, 2, '098 1530 0023', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Mirko', 'Ademi', '00000000024', '01.01.1990', 3, 9, 2, '098 1530 0024', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Viktor', 'Hugo', '00000000025', '01.01.1990', 4, 9, 5, '098 1530 0025', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Hugo', 'Hugoviæ', '00000000026', '01.01.1990', 4, 9, 5, '098 1530 0026', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Hrvoje', 'Ademi', '00000000027', '01.01.1990', 2, 9, 5, '098 1530 0027', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Mirka', 'Trombon', '00000000028', '01.01.1990', 2, 10, 5, '098 1530 0028', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Mirta', 'Dren', '00000000029', '01.01.1990', 1, 10, 5, '098 1530 0029', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Miroslava', 'Josipoviæ', '00000000030', '01.01.1990', 1, 10, 4, '098 1530 0030', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Višnja', 'Voæko', '00000000031', '01.01.1990', 1, 10, 4, '098 1530 0031', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Jagoda', 'Voæko', '00000000032', '01.01.1990', 3, 10, 4, '098 1530 0032', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Zdenko', 'Sir', '00000000033', '01.01.1990', 2, 9, 8, '098 1530 0033', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Zekoslav', 'Mrkva', '00000000034', '01.01.1990', 4, 9, 7, '098 1530 0034', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Tom', 'Maèak', '00000000035', '01.01.1990', 5, 9, 5, '098 1530 0035', 1, @InsertDatum, NULL)
INSERT INTO DONOR VALUES('Zen', 'Maèak', '00000000036', '01.01.1990', 5, 9, 2, '098 1530 0036', 1, @InsertDatum, NULL)

INSERT INTO DONOR VALUES('Mica', 'Maca', '00000000037', '01.01.1990', 5, 10, 2, '098 1530 0037', 1, @InsertDatum, NULL)

CREATE PROCEDURE Donor_Select(@Oib VARCHAR(11))
AS BEGIN
	SELECT * 
	FROM DONOR
	WHERE @Oib IS NULL 
		OR (Oib = @Oib)
end;

CREATE PROCEDURE Donor_Delete(@Id INT)
AS 
	BEGIN 
		DELETE FROM DONOR
		WHERE ID = @Id
END

CREATE PROCEDURE [dbo].[DONOR_UPDATE]
(
	@Update smallint,
	@Ime VARCHAR(50),
	@Prezime VARCHAR(50),
	@Oib VARCHAR(11),
	@RodjenDatum DATE,
	@GradId INT,
	@Spol INT,
	@KrvaGrupa INT,
	@KontaktBroj VARCHAR(30),
	@AktivanDonor BIT
)
AS BEGIN

	DECLARE @TrenutnoVrijeme DATETIME = GETDATE();

	IF @Update = 0 BEGIN
		INSERT INTO DONOR(Ime, Prezime, Oib, RodjenDatum, GradId, Spol, KrvaGrupa, KontaktBroj, AktivanDonor, DatumInsert, DatumUpdate)
		VALUES(@Ime, @Prezime, @Oib, @RodjenDatum, @GradId, @Spol, @KrvaGrupa, @KontaktBroj, 1, @TrenutnoVrijeme, NULL);
	END
	ELSE BEGIN
		
		DECLARE @Id INT = (SELECT ID FROM Donor WHERE Oib = @Oib);
		
		UPDATE DONOR
		SET  
			Ime = @Ime,
			Prezime = @Prezime,
			Oib = @Oib,
			RodjenDatum = @RodjenDatum,
			GradId = @GradId,
			Spol = @Spol,
			KrvaGrupa = @KrvaGrupa,
			KontaktBroj = @KontaktBroj,
			AktivanDonor = @AktivanDonor,
			DatumUpdate = @TrenutnoVrijeme
		WHERE Id = Oib;
	END
END

CREATE Table Korisnik
(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	KorisnickoIme VARCHAR(50) NOT NULL UNIQUE,
	Sifra VARCHAR(50) NOT NULL
)

INSERT INTO Korisnik VALUES('admin', 'test');

CREATE VIEW StatistikaGrad AS
SELECT
   bd.brojDonora * 0.450 AS Kolicina,
   g.Naziv AS Naziv
FROM
(
	SELECT 
	  COUNT(ref.ID) as brojDonora,
	  ref.Naziv,
	  d.GradId
	FROM DONOR d
	INNER JOIN Referenca ref ON d.KrvaGrupa = ref.ID AND d.Spol = d.Spol
	GROUP BY ref.ID, ref.Naziv, d.GradId
) AS bd
INNER JOIN Grad g ON g.ID = bd.GradId


CREATE VIEW KolicinaKrvi AS
	SELECT 
		KolicinaKrvi AS Kolicina,
		KrvnaGrupa AS Naziv
	FROM (
	SELECT 
	  COUNT(ref.ID) * 0.450 as KolicinaKrvi,
	  ref.Naziv AS KrvnaGRUPA
	FROM DONOR d
	INNER JOIN Referenca ref ON d.KrvaGrupa = ref.ID AND d.Spol = d.Spol
	GROUP BY ref.ID, ref.Naziv
) as kk 
