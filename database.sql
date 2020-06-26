CREATE DATABASE [Studentski_Centar]
USE [Studentski_Centar]
GO

/****** Object:  Table [dbo].[studentiObrisano]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[studentiObrisano](
	[ID_studenta] [int] NULL,
	[br_indeksa] [varchar](20) NULL,
	[ime] [varchar](30) NULL,
	[prezime] [varchar](40) NULL,
	[pol] [char](1) NULL,
	[datum_rodjenja] [date] NULL,
	[fakultet] [varchar](40) NULL,
	[godina_studija] [int] NULL,
	[telefon] [varchar](30) NULL,
	[ID_sobe] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO



/****** Object:  Table [dbo].[paviljon]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[paviljon](
	[ID_paviljona] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[adresa] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_paviljona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO




/****** Object:  Table [dbo].[administracija]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[administracija](
	[ID_admin] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](30) NOT NULL,
	[prezime] [varchar](40) NOT NULL,
	[detalji] [varchar](20) NULL,
	[korisnicko_ime] [varchar](50) NULL,
	[lozinka] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_admin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO




/****** Object:  StoredProcedure [dbo].[ispisIDblagajnika]    Script Date: 06/26/2020 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ispisIDblagajnika]
@imeBlagajnika VARCHAR(30),
@prezimeBlagajnika VARCHAR(40),
@IDblagajnika INT OUTPUT

AS
BEGIN

SELECT @IDblagajnika=ID_admin FROM administracija
WHERE ime=@imeBlagajnika AND prezime=@prezimeBlagajnika

END
GO





/****** Object:  Table [dbo].[sobe]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sobe](
	[ID_sobe] [int] IDENTITY(1,1) NOT NULL,
	[br_studenata] [int] NOT NULL,
	[broj_kreveta] [int] NOT NULL,
	[ID_paviljona] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_sobe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO






/****** Object:  StoredProcedure [dbo].[prijavaProcedura]    Script Date: 06/26/2020 19:34:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prijavaProcedura] @korisnickoIme VARCHAR(50),
								  @lozinka VARCHAR(255)

AS
BEGIN
SELECT COUNT(*) FROM administracija WHERE korisnicko_ime=@korisnickoIme AND lozinka=@lozinka;
END
GO





/****** Object:  Table [dbo].[studenti]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[studenti](
	[ID_studenta] [int] IDENTITY(1,1) NOT NULL,
	[br_indeksa] [varchar](20) NOT NULL,
	[ime] [varchar](30) NOT NULL,
	[prezime] [varchar](40) NOT NULL,
	[pol] [char](1) NULL,
	[datum_rodjenja] [date] NULL,
	[fakultet] [varchar](40) NOT NULL,
	[godina_studija] [int] NOT NULL,
	[telefon] [varchar](30) NULL,
	[ID_sobe] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_studenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[br_indeksa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO




/****** Object:  StoredProcedure [dbo].[ispisSlobodnihMjesta]    Script Date: 06/26/2020 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ispisSlobodnihMjesta]
AS
SELECT naziv, ID_sobe as Broj_sobe, (broj_kreveta-br_studenata) as Br_slobodnih_kreveta FROM sobe JOIN 
paviljon ON sobe.ID_paviljona=paviljon.ID_paviljona
 WHERE (broj_kreveta - br_studenata) > 0;
GO





/****** Object:  StoredProcedure [dbo].[ispisIDiS]   Script Date: 06/26/2020 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ispisIDiS] 
							@imeStudenta VARCHAR(30),
							@prezimeStudenta VARCHAR(40),
							@fakultet VARCHAR(40),
							@IDs INT OUTPUT,
							@BrSobe INT OUTPUT

AS
begin

 SELECT @IDs=ID_studenta FROM studenti WHERE
 ime=@imeStudenta AND prezime=@prezimeStudenta AND fakultet=@fakultet

SELECT @BrSobe=ID_sobe FROM studenti WHERE
 ime=@imeStudenta AND prezime=@prezimeStudenta AND fakultet=@fakultet
 
end
GO




/****** Object:  StoredProcedure [dbo].[dodajStudenta]    Script Date: 06/26/2020 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[dodajStudenta] @br_indeksa VARCHAR(20),
							  @ime VARCHAR(30),
							  @prezime VARCHAR(40),
							  @pol CHAR(1),
							  @datum_rodjenja DATE,
							  @fakultet VARCHAR(40),
							  @godina_studija INT,
							  @telefon VARCHAR(30),
						    @ID_sobe INT						      						   					 
 AS

 SET NOCOUNT ON
 DECLARE @br_studenata int
   SET @br_studenata = (SELECT br_studenata FROM sobe WHERE ID_sobe=@ID_sobe)
 
 DECLARE @brojKreveta int
   SET @brojKreveta = (SELECT broj_kreveta FROM sobe WHERE ID_sobe=@ID_sobe)
 
 IF(@br_studenata < @brojKreveta)
	BEGIN
	 INSERT INTO studenti(br_indeksa,
						  ime,
						  prezime,
						  pol,
						  datum_rodjenja,
						  fakultet,
						  godina_studija,
						  telefon,
						  ID_sobe)
							  
				 VALUES ( @br_indeksa,
						 @ime,
						 @prezime,
						 @pol,
						 @datum_rodjenja, 
	   				 @fakultet, 
						 @godina_studija, 
						 @telefon,
						 @ID_sobe)
											 
	UPDATE sobe SET br_studenata=br_studenata+1 WHERE ID_sobe=@ID_sobe;
	print 'Podaci su uspjesno sacuvani!';
END

ELSE
	BEGIN
	print 'Nemoguc unos, nema slobodnih mjesta!';
END
GO




/****** Object:  StoredProcedure [dbo].[pretragaSoba]    Script Date: 06/26/2020 19:34:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pretragaSoba]   @ID_paviljona INT,
										@ID_sobe INT
AS
BEGIN
SELECT ime,prezime,studenti.ID_sobe as 'broj sobe',naziv,br_studenata as 'broj studenata', broj_kreveta as 'broj kreveta' FROM studenti 
JOIN sobe ON studenti.ID_sobe = sobe.ID_sobe
JOIN paviljon ON sobe.ID_paviljona = paviljon.ID_paviljona 
WHERE sobe.ID_paviljona = @ID_paviljona AND sobe.ID_sobe =@ID_sobe
END
GO



/****** Object:  Table [dbo].[ugovor]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ugovor](
	[ID_ugovora] [int] IDENTITY(1,1) NOT NULL,
	[sifra_ugovora] [varchar](10) NULL,
	[datum] [datetime] NOT NULL,
	[dat_isteka] [datetime] NULL,
	[ID_studenta] [int] NOT NULL,
	[ID_admin] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ugovora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO



/****** Object:  Table [dbo].[uplate]    Script Date: 06/26/2020 19:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uplate](
	[ID_uplate] [int] IDENTITY(1,1) NOT NULL,
	[iznos] [decimal](6, 2) NOT NULL,
	[duguje] [decimal](6, 2) NULL,
	[potrazuje] [decimal](6, 2) NULL,
	[ID_studenta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
([ID_uplate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




/****** Object:  StoredProcedure [dbo].[unosStudentaVjezba]    Script Date: 06/26/2020 19:34:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[unosStudentaVjezba] @br_indeksa VARCHAR(20),
							  @ime VARCHAR(30),
							  @prezime VARCHAR(40),
							  @pol CHAR(1),
							  @datum_rodjenja DATE,
							  @fakultet VARCHAR(40),
							  @godina_studija INT,
							  @telefon VARCHAR(30),
						      @ID_sobe INT
 
 AS
  BEGIN
  SET NOCOUNT ON
 
	 INSERT INTO studenti(br_indeksa,ime,prezime,pol,datum_rodjenja,fakultet,godina_studija,telefon,ID_sobe)
	 VALUES (@br_indeksa, @ime, @prezime, @pol, @datum_rodjenja, @fakultet, @godina_studija, @telefon, @ID_sobe)
	 
 END
GO








/****** Object:  StoredProcedure [dbo].[ugovoriIspis]    Script Date: 06/26/2020 19:34:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ugovoriIspis] 
								@imeStudenta VARCHAR(30),
								@prezimeStudenta VARCHAR(40)
AS
BEGIN

SELECT sifra_ugovora, datum as 'Datum sklapanja ugovora', dat_isteka AS 'Datum isteka ugovora', studenti.ime + ' ' + studenti.prezime as 'Ime i prezime studenta',
fakultet, studenti.ID_sobe as 'Broj sobe', administracija.ime + ' '+ administracija.prezime as 'Ime i prezime blagajnika'
FROM studenti JOIN ugovor ON studenti.ID_studenta=ugovor.ID_studenta 
JOIN  administracija ON administracija.ID_admin=ugovor.ID_admin 
WHERE studenti.ime=@imeStudenta AND studenti.prezime=@prezimeStudenta;

END
GO







/****** Object:  StoredProcedure [dbo].[unosUgovorUplata]    Script Date: 06/26/2020 19:34:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[unosUgovorUplata]
@sifraUgovora VARCHAR(10),
@datumSklapanjaUgovora DATETIME,
@datumIstekaUgovora datetime,
@ID_studenta INT,
@ID_blagajnika INT,
@iznos DECIMAL(6,2),
@duguje DECIMAL(6,2),
@potrazuje DECIMAL(6,2)

AS
BEGIN

INSERT INTO ugovor (sifra_ugovora,datum,dat_isteka,ID_studenta,ID_admin) VALUES (@sifraUgovora,
																			                                           @datumSklapanjaUgovora,
																				                                         @datumIstekaUgovora,
																				                                         @ID_studenta,
																			                                         	 @ID_blagajnika)
																				 
INSERT INTO uplate(iznos,duguje,potrazuje,ID_studenta) VALUES (@iznos,
																@duguje,
																@potrazuje,
																@ID_studenta)




END
GO







/****** Object:  View [dbo].[PodaciStudenta]    Script Date: 06/26/2020 19:34:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PodaciStudenta] AS

SELECT ime + ' ' + prezime as 'Ime i prezime',fakultet AS 'Fakultet', godina_studija AS 'Godina studija',
 naziv as 'Broj paviljona', sobe.id_sobe AS 'Broj sobe', potrazuje as 'Uplacen iznos',
 datum as 'Datum sklapanja ugovora', 
 dat_isteka as 'Datum isteka ugovora'
FROM studenti JOIN sobe ON studenti.ID_sobe=sobe.ID_sobe
JOIN paviljon ON paviljon.ID_paviljona=sobe.ID_paviljona 
JOIN ugovor ON ugovor.ID_studenta=studenti.ID_studenta JOIN uplate ON
uplate.ID_studenta=studenti.ID_studenta;
GO





/****** Object:  StoredProcedure [dbo].[noviUgovor]    Script Date: 06/26/2020 19:34:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[noviUgovor]	 @imeStudenta VARCHAR(30),
    						                     @prezimeStudenta VARCHAR(40),							 
							                       @sifraUgovora VARCHAR(10),
						                      	 @ID_admin INT
							 							
AS							 							
SET NOCOUNT ON
	declare @ID_studenta INT, @datumSklapanjaUgovora datetime,@datumIstekaUgovora DATETIME
	
	SET @ID_studenta=(SELECT ID_studenta FROM studenti WHERE ime=@imeStudenta AND prezime=@prezimeStudenta)
	SET @datumSklapanjaUgovora=(SELECT GETDATE())
	SET @datumIstekaUgovora=(SELECT GETDATE()+30)
	
	BEGIN
	
	INSERT INTO ugovor (sifra_ugovora,
						datum,
						dat_isteka,
						ID_studenta,
						ID_admin)
	VALUES				
						(@sifraUgovora,
						 @datumSklapanjaUgovora,
						 @datumIstekaUgovora,
						 @ID_studenta,
						 @ID_admin)
	select @ID_studenta;
	select @datumSklapanjaUgovora;
	SELECT @datumIstekaUgovora;
END
GO



/****** Object:  StoredProcedure [dbo].[ispisStudent]    Script Date: 06/26/2020 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ispisStudent] @ime VARCHAR(30),
							  @prezime  VARCHAR(40)
AS
BEGIN

SELECT studenti.ID_studenta,ime,prezime,pol,datum_rodjenja,telefon,fakultet,godina_studija,br_indeksa,
naziv,sobe.ID_sobe as 'broj sobe',uplate.potrazuje as 'uplaceno',ugovor.datum as 'datum sklapanja ugovora',
ugovor.dat_isteka as 'datum isteka ugovora'
FROM  studenti  JOIN sobe ON studenti.ID_sobe = sobe.ID_sobe 
JOIN paviljon ON paviljon.ID_paviljona = sobe.ID_paviljona JOIN ugovor ON ugovor.ID_studenta = studenti.ID_studenta JOIN
uplate ON uplate.ID_studenta = studenti.ID_studenta WHERE ime LIKE @ime +'%' AND prezime LIKE @prezime +'%';


END
GO




/****** Object:  StoredProcedure [dbo].[brisanje]    Script Date: 06/26/2020 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[brisanje] 
							  @ID_studenta INT,
						    @ID_sobe INT
						      
AS 
BEGIN
SET NOCOUNT ON

INSERT INTO studentiObrisano SELECT * FROM studenti WHERE ID_studenta=@ID_studenta;

DELETE From ugovor WHERE ID_studenta=@ID_studenta;
DELETE FROM uplate WHERE ID_studenta=@ID_studenta;
DELETE  FROM studenti WHERE ID_studenta=@ID_studenta;

UPDATE sobe SET br_studenata=br_studenata-1 WHERE ID_sobe=@ID_sobe;
END
GO




/****** Object:  Default [DF__ugovor__datum__276EDEB3]    Script Date: 06/26/2020 19:34:38 ******/
ALTER TABLE [dbo].[ugovor] ADD  DEFAULT (getutcdate()) FOR [datum]
GO



/****** Object:  ForeignKey [FK__sobe__ID_paviljo__060DEAE8]    Script Date: 06/26/2020 19:34:38 ******/
ALTER TABLE [dbo].[sobe]  WITH CHECK ADD FOREIGN KEY([ID_paviljona])
REFERENCES [dbo].[paviljon] ([ID_paviljona])
GO


/****** Object:  ForeignKey [FK__studenti__ID_sob__0DAF0CB0]    Script Date: 06/26/2020 19:34:38 ******/
ALTER TABLE [dbo].[studenti]  WITH CHECK ADD FOREIGN KEY([ID_sobe])
REFERENCES [dbo].[sobe] ([ID_sobe])
GO


/****** Object:  ForeignKey [FK__ugovor__ID_admin__29572725]    Script Date: 06/26/2020 19:34:38 ******/
ALTER TABLE [dbo].[ugovor]  WITH CHECK ADD FOREIGN KEY([ID_admin])
REFERENCES [dbo].[administracija] ([ID_admin])
GO


/****** Object:  ForeignKey [FK__ugovor__ID_stude__286302EC]    Script Date: 06/26/2020 19:34:38 ******/
ALTER TABLE [dbo].[ugovor]  WITH CHECK ADD FOREIGN KEY([ID_studenta])
REFERENCES [dbo].[studenti] ([ID_studenta])
GO


/****** Object:  ForeignKey [FK__uplate__ID_stude__173876EA]    Script Date: 06/26/2020 19:34:38 ******/
ALTER TABLE [dbo].[uplate]  WITH CHECK ADD FOREIGN KEY([ID_studenta])
REFERENCES [dbo].[studenti] ([ID_studenta])
GO
