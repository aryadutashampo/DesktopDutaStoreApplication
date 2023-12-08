CREATE DATABASE duta_store;
USE duta_store;
DROP DATABASE duta_store;

CREATE TABLE akun_pelanggan(
account_id	INT AUTO_INCREMENT PRIMARY KEY,
username	VARCHAR(10) NOT NULL,
pw		VARCHAR(8) NOT NULL
);

INSERT INTO akun_pelanggan VALUES 
(1, 'Arya14', '140304');

CREATE TABLE info_pelanggan(
user_id		INT AUTO_INCREMENT PRIMARY KEY,
nama		VARCHAR(20) NOT NULL,
email		VARCHAR(30) NOT NULL
);

INSERT INTO info_pelanggan VALUES
(1,'Arya Duta Adirajasa', 'arya14@gmail.com');

CREATE TABLE barang(
id_barang	INT PRIMARY KEY,
nama_barang	VARCHAR(50),
harga		INT,
stok		INT,
photo		LONGBLOB
);

INSERT INTO barang VALUES
(1, "Masako", 5000, 50, NULL);

CREATE TABLE history(
user_id			INT,
id_barang		INT,
jumlah			INT,
total			INT,
FOREIGN KEY (user_id) REFERENCES info_pelanggan(user_id),
FOREIGN KEY (id_barang) REFERENCES barang(id_barang)
);

INSERT INTO history VALUES
(1,1,5,25000);

