--CREATE DATABASE DBBiblioteca
--GO

USE DBBiblioteca
GO

IF OBJECT_ID('Cartilla') IS NULL BEGIN 
Create Table Cartilla (
	nId int Primary Key Not Null Identity(1,1),
	cTitle varchar (200) Not Null,
	cDescription varchar (Max) Not Null,
	cPhotography varchar (Max) Null,
	cTextButton varchar (50) Not Null,
	cLinkButton varchar (Max) Not Null
)
END
GO

INSERT INTO Cartilla (cTitle, cDescription, cPhotography, cTextButton, cLinkButton)
VALUES ('Recursos Libres', 'Aqui encontraras los recursos virtuales de libre acceso.', 'C:\\User\ALME\libros.jpg', 'Ir a Recursos Libres', 'http://recursoslibres.com.pe')

GO
SELECT * FROM Cartilla

GO




/****SPs***/
If OBJECT_ID('sp_sel_Cartillas') IS NOT NULL BEGIN DROP PROC sp_sel_Cartillas END
GO
Create procedure sp_sel_Cartillas 
As
Begin

	Select cTitle, cDescription, cPhotography, cTextButton, cLinkButton
	from Cartilla
End
GO

If OBJECT_ID('sp_sel_Cartillas') IS NOT NULL BEGIN DROP PROC sp_sel_Cartillas END
GO
Create procedure sp_upd_Cartillas (
@nId int,
@cTitle varchar (100), 
@cDescription varchar (Max), 
@cPhotography varchar (100), 
@cTextButton varchar (50), 
@cLinkButton varchar (Max)
)
As
Begin
	
	Update Cartilla set cTitle=@cTitle, cDescription=@cDescription, cPhotography=@cPhotography, cTextButton=@cTextButton, cLinkButton=@cLinkButton
	where nId=@nId
End