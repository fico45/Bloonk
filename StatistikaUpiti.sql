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
