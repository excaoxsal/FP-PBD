CREATE DATABASE DBPBD_PendaftaranSiswa
ON PRIMARY (
	NAME = Proyek_Pbd,
	FILENAME = 'E:\My Data\Tugas\PBD\FP-PBD\DBPBD_PendaftaranSiswa.mdf',
	SIZE = 10,
	MAXSIZE = 50,
	FILEGROWTH = 2)
LOG ON (
	NAME = db_psb_log,
	FILENAME = 'E:\My Data\Tugas\PBD\FP-PBD\DBPBD_PendaftaranSiswalog.ldf',
	SIZE = 5,
	MAXSIZE = 20,
	FILEGROWTH = 1)

	USE DBPBD_PendaftaranSiswa
	use master
	drop database PROYEK_PBD
	--MEMBUAT TABLE

	CREATE TABLE STAFF(
	ID_STAFF varCHAR (12) NOT NULL PRIMARY KEY,
	PASS_STAFF VARCHAR (25) NOT NULL,
	NAMA_STAFF VARCHAR (100) NOT NULL,
	ALAMAT_STAFF VARCHAR (100) NOT NULL,
	NO_TELP_STAFF INT NOT NULL,
	EMAIL_STAFF VARCHAR (50) NOT NULL
	)

	CREATE TABLE CALONSISWA(
	ID_CALONSISWA varCHAR (12) NOT NULL PRIMARY KEY,
	NISN varchar (15) not null,
	NAMA_CALONSISWA VARCHAR(100) NOT NULL,
	JENIS_KELAMIN varchar(2) not null,
	TGL_LAHIR varchar(8) not null,
	ALAMAT_CALONSISWA VARCHAR (100) NOT NULL,
	NO_TELP_CALONSISWA INT NOT NULL,
	EMAIL_CALONSISWA VARCHAR (50) NOT NULL,
	TH_DAFTAR INT NOT NULL,
	JURUSAN VARCHAR (25) NOT NULL,
	ID_STAFF varCHAR(12) FOREIGN KEY REFERENCES STAFF(ID_STAFF),
	NILAI_UJIAN INT NOT NULL,
	STATUS_CalonSISWA CHAR (10) NOT NULL
	)
	

	CREATE TABLE JURUSAN(
	ID_JURUSAN varCHAR(8) NOT NULL PRIMARY KEY,
	NAMA_JURUSAN VARCHAR(25) NOT NULL
	)

	

	CREATE TABLE GURU(
	ID_GURU varCHAR (12) NOT NULL PRIMARY KEY,
	NAMA_GURU VARCHAR (100) NOT NULL,
	ALAMAT_GURU VARCHAR (100) NOT NULL,
	NO_TELP_GURU INT NOT NULL,
	EMAIL_GURU VARCHAR (50) NOT NULL,
	JABATAN CHAR (25) NOT NULL
	)
	
	EXEC sp_RENAME 'guru.email_staff', 'EMAIL_GURU', 'COLUMN'
	

	CREATE TABLE PEMBAYARAN (
	ID_PEMBAYARAN varCHAR (12) NOT NULL PRIMARY KEY,
	NAMA_PEMBAYARAN VARCHAR (100) NOT NULL,
	HARGA FLOAT NOT NULL
	)

	CREATE TABLE SISWA(
	ID_SISWA varCHAR (12) NOT NULL PRIMARY KEY,
	NAMA_SISWA VARCHAR(100) NOT NULL,
	JENIS_KELAMIN varchar(2) not null,
	TGL_LAHIR varchar(8) not null,
	ALAMAT_SISWA VARCHAR (100) NOT NULL,
	NO_TELP_SISWA VARCHAR (12) NOT NULL,
	EMAIL_SISWA VARCHAR (50) NOT NULL,
	TH_ANGKATAN INT NOT NULL,
	
	)
	alter table siswa
	alter column NO_TELP_SISWA INT(12) NOT NULL

	create table TRANSAKSI(
	ID_NOTA varchar (12) not null primary key,
	ID_PEMBAYARAN varCHAR (12) NOT NULL foreign key references PEMBAYARAN(ID_PEMBAYARAN),
	ID_SISWA varCHAR (12) NOT NULL FOREIGN KEY REFERENCES SISWA (ID_SISWA),
	TANGGAL DATE,
	)

	CREATE TABLE DETAIL_TRANSAKSI(
	ID_NOTA VARCHAR (12) NOT NULL FOREIGN KEY REFERENCES TRANSAKSI (ID_NOTA),
	ID_PEMBAYARAN varCHAR (12) NOT NULL foreign key references PEMBAYARAN(ID_PEMBAYARAN),
	TOTAL_BARANG INT,
	HARGA INT,
	)
	create tabLE KELAS (
	ID_KELAS VARCHAR (2) NOT NULL PRIMARY KEY,
	ID_SISWA varCHAR (12) NOT NULL FOREIGN KEY REFERENCES SISWA(ID_SISWA),
	ID_GURU varCHAR (12) NOT NULL FOREIGN KEY REFERENCES GURU(ID_GURU),
	ID_JURUSAN varCHAR(8) NOT NULL foreign key references jurusan(id_jurusan)
	)
	DROP TABLE SISWA