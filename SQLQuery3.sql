USE [Bloonk]
GO
/****** Object:  StoredProcedure [dbo].[DONOR_UPDATE]    Script Date: 21.1.2018. 16:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DONOR_UPDATE]
(
	@ID int,
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

	IF @ID = 0 BEGIN
		INSERT INTO DONOR(Ime, Prezime, Oib, RodjenDatum, GradId, Spol, KrvaGrupa, KontaktBroj, AktivanDonor, DatumInsert, DatumUpdate)
		VALUES(@Ime, @Prezime, @Oib, @RodjenDatum, @GradId, @Spol, @KrvaGrupa, @KontaktBroj, 1, @TrenutnoVrijeme, NULL);
	END
	ELSE IF @ID > 0 BEGIN
		
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
		WHERE Id = @ID;
	END
END