USE Biblioteka
GO

CREATE TABLE Clanovi(
ClanID INT IDENTITY NOT NULL,
Ime NVARCHAR(30) NOT NULL,
Prezime NVARCHAR(40) NOT NULL,
Telefon NVARCHAR(20) NOT NULL,
Adresa NVARCHAR(50) NOT NULL,
Mesto NVARCHAR(50) NOT NULL,
Email NVARCHAR(50) NOT NULL,
DatumUclanjena DATE NOT NULL DEFAULT GETDATE()
)

GO
CREATE TABLE Knjige(
KnjigaID INT IDENTITY NOT NULL,
Naziv NVARCHAR(50) NOT NULL,
Pisac NVARCHAR(50) NOT NULL,
Zanr NVARCHAR(30) NOT NULL,
BrojStrana NVARCHAR (10) NOT NULL
)

GO
create table IzdateKnjige(
KnjigaID int not null,
Naziv nvarchar (70) not null,
Pisac nvarchar (70) not null,
ClanID int not null,
Ime nvarchar(40) not null,
Prezime nvarchar(50) not null
)