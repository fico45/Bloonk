/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[Ime]
      ,[Prezime]
      ,[Oib]
      ,[RodjenDatum]
      ,[GradId]
      ,[Spol]
      ,[KrvaGrupa]
      ,[KontaktBroj]
      ,[AktivanDonor]
      ,[DatumInsert]
      ,[DatumUpdate]
  FROM [Bloonk].[dbo].[DONOR]

  delete from DONOR where id = 1041