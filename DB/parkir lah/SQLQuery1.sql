create database parkir

create table parkir
(id_parkir varchar(15) not null primary key,
jenis_kend varchar(10),
tgl_masuk datetime,
kode_lokasi varchar(5),
)

create table lokasi
(kode_lokasi varchar (5) not null primary key,
jenis_kend varchar (10),
kuota int,
)

create table operator
(NIK varchar (10) primary key,
nama varchar (50),
pasword varchar (15),
level varchar (100),
)

create table karyawan
(NIK varchar (10) primary key,
nama varchar (50),
alamat varchar (100),
instansi varchar (100),
)

create table transaksi
(id_parkir varchar(15),
jenis_kend varchar (10),
tgl_masuk datetime,
tgl_keluar datetime,
harga int,
nik varchar (10)
)

alter table parkir add constraint parkir_lokasi foreign key (kode_lokasi) references lokasi (kode_lokasi) ON DELETE CASCADE ON UPDATE CASCADE;
alter table transaksi add constraint transaksi_operator foreign key (nik) references operator (NIK) ON DELETE CASCADE ON UPDATE CASCADE;
alter table operator add constraint operator_karyawan foreign key (NIK) references karyawan (NIK) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE PROCEDURE hapus_parkir @id_parkir varchar(15) AS
	delete from parkir where id_parkir = @id_parkir;

CREATE PROCEDURE tambah_kend @id_parkir varchar(15), @jenis_kend varchar(7), @tgl_masuk datetime, @kode_lokasi varchar(10) AS
	insert into parkir values (@id_parkir, @jenis_kend, @tgl_masuk, @kode_lokasi);

CREATE PROCEDURE tambah_lokasi @kode_lokasi varchar(10), @jenis_kend varchar(10), @kuota int AS
	IF EXISTS(SELECT * FROM lokasi WHERE kode_lokasi = @kode_lokasi)
		UPDATE lokasi SET kuota = @kuota, jenis_kend = @jenis_kend
		WHERE kode_lokasi = @kode_lokasi
	ELSE
		insert into lokasi values (@kode_lokasi, @jenis_kend, @kuota);

DROP PROCEDURE tambah_lokasi;

CREATE PROCEDURE hapus_lokasi @kode_lokasi varchar(10) AS
	delete from lokasi where kode_lokasi = @kode_lokasi;

CREATE PROCEDURE tambah_karyawan @NIK VARCHAR(10), @nama VARCHAR(50), @alamat varchar(100), @instansi varchar(100) AS
	IF EXISTS(SELECT * FROM karyawan WHERE NIK = @NIK)
		BEGIN
			UPDATE karyawan SET nama = @nama, alamat = @alamat, instansi = @instansi
			WHERE NIK = @NIK;
			UPDATE operator SET nama = @nama
			WHERE NIK = @NIK;
		END;
	ELSE
		INSERT INTO karyawan VALUES (@NIK, @nama, @alamat, @instansi);

CREATE PROCEDURE delete_karyawan @NIK VARCHAR(10) AS 
	DELETE FROM karyawan WHERE NIK = @NIK;

CREATE PROCEDURE tambah_operator @NIK VARCHAR(10), @nama VARCHAR(50), @password varchar(15), @level varchar(100) AS
	IF EXISTS(SELECT * FROM operator WHERE NIK = @NIK)
		UPDATE operator SET level = @level
		WHERE NIK = @NIK
	ELSE
		INSERT INTO operator VALUES (@NIK, @nama, @password, @level);

CREATE PROCEDURE delete_operator @NIK VARCHAR(10) AS 
	DELETE FROM operator WHERE NIK = @NIK;

INSERT INTO lokasi VALUES ('A01', 'Motor', 2);
INSERT INTO lokasi VALUES ('A02', 'Motor', 2);
INSERT INTO lokasi VALUES ('B01', 'Mobil', 2);
INSERT INTO lokasi VALUES ('B02', 'Mobil', 2);
INSERT INTO lokasi VALUES ('C01', 'Karyawan', 2);

INSERT INTO karyawan VALUES ('1234', 'DwiChan', 'Dimana Aja', 'Gatau ah');
INSERT INTO operator VALUES ('1234', 'DwiChan', '1123', 'Admin');
INSERT INTO karyawan VALUES ('4567', 'Adinda Ayundra', 'Dimana Aja', 'Gatau ah');
INSERT INTO operator VALUES ('4567', 'Adinda Ayundra', '1123', 'Operator');

SELECT * FROM operator;
TRUNCATE TABLE transaksi;

ALTER DATABASE parkir
SET MULTI_USER
WITH ROLLBACK IMMEDIATE