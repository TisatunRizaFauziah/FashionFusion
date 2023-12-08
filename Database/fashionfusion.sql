CREATE DATABASE FashionFusion;
USE FashionFusion;


CREATE TABLE  kategori(
	id_kategori CHAR(5)PRIMARY KEY,
	nama_kategori VARCHAR (100)
);

CREATE TABLE  pelanggan(
	id_pelanggan CHAR(5) PRIMARY KEY,
	nama_pelanggan	VARCHAR (100),
	alamat	VARCHAR (100)
);

CREATE TABLE distributor(
	id_distributor	CHAR(5) PRIMARY KEY,
	nama_distributor VARCHAR (100),
	alamat	VARCHAR (100)	
);

CREATE TABLE  pakaian(
	id_pakaian CHAR(5)PRIMARY KEY,
	nama_pakaian VARCHAR (100),
	id_kategori CHAR(5),
	harga INT,
	ukuran CHAR(5),
	stok INT
		
	
);

ALTER TABLE pakaian add CONSTRAINT fk_pakaian FOREIGN KEY (id_kategori) REFERENCES kategori(id_kategori);


CREATE TABLE penjualan(
	id_penjualan CHAR(5)PRIMARY KEY,
	tanggal_penjualan DATE,
	id_pelanggan CHAR(5),
	id_pakaian CHAR(5),	
	jumlah	INT
		
);

ALTER TABLE penjualan ADD CONSTRAINT fk_penjualan FOREIGN KEY (id_pakaian) REFERENCES pakaian(id_pakaian);
ALTER TABLE penjualan ADD constraint fk_penjualan_2 FOREIGN KEY (id_pelanggan) REFERENCES pelanggan(id_pelanggan);
	
CREATE TABLE pembelian(
	id_pembelian CHAR(5),
	tanggal_pembelian DATE,
	id_distributor CHAR(5),
	id_pakaian CHAR(5),	
	jumlah	INT,
	PRIMARY KEY(id_pembelian)
	
);

ALTER TABLE pembelian ADD CONSTRAINT fk_pembelian FOREIGN KEY (id_pakaian) REFERENCES pakaian(id_pakaian);
ALTER TABLE pembelian ADD CONSTRAINT fk_pembelian_2 FOREIGN KEY (id_distributor) REFERENCES distributor(id_distributor);

CREATE TABLE admin(
id CHAR(5) PRIMARY KEY,
admin VARCHAR(100),
passwoard VARCHAR(100)

);

INSERT INTO kategori VALUES ('K01','BAJU'),('K02','CELANA'),('K03','ROK'),('K04','KERUDUNG'),('K05','JAKET');


INSERT INTO pelanggan VALUES
('PL001', 'Imron Sihaloho','Sibolga'),
('PL002', 'Yanti Nurhayati','Ciamis'),
('PL003', 'Hilwa Isnaini Marfuah','Salatiga'),
('PL004', 'Fadly Ariyansyah P','Sipirok'),
('PL005', 'Sandi Andrian N. T','Sibolga'),
('PL006', 'Ayra Duta Adirajasa','Bandung'),
('PL007', 'Nurjamilah','Bandung'),
('PL008', 'Fadillah Aulia M ','Kebumen'),
('PL009', 'Ades Roydatul Adillah','Banjar'),
('PL010', 'Arya Segara','Pekanbaru');


INSERT INTO distributor VALUES
('D0001', 'Marfuah Collection', 'Jl. Siliwangi No.80'),
('D0002', 'Andrian Fashion', 'Jl. Husein Kertassamita '),
('D0003', 'Hayati Butik', 'Jl. Ciamis Manis'),
('D0004', 'Ariyansyah Fashion', 'Jl. Pahlawan No.28'),
('D0005', 'Sihaloho Collection', 'Jl. Gardu Raya');


INSERT INTO pakaian VALUES 
('PK01', 'Kemeja Polos'		, 'K01', '60000', 'S', 50),
('PK02', 'Kemeja Polos'		, 'K01', '65000', 'M', 50),
('PK03', 'Kemeja Polos'		, 'K01', '70000', 'L',50),
('PK04', 'Celana Joger'		, 'K02', '50000','S', 50),
('PK05', 'Celana Joger'		, 'K02', '55000','M', 50),
('PK06', 'Celana Joger'		, 'K02', '60000','L', 50);


INSERT INTO penjualan VALUES
('PJ001', '2023-03-30', 'PL001', 'PK01', '3'),
('PJ002', '2023-03-31', 'PL003', 'PK02', '5'),
('PJ003', '2023-03-31', 'PL004', 'PK01', '1');


INSERT INTO pembelian VALUES
('PB001', '2023-03-30', 'D0001', 'PK01', '3'),
('PB002', '2023-03-30', 'D0003', 'PK02', '5'),
('PB003', '2023-03-31', 'D0005', 'PK01', '1');



INSERT INTO admin VALUES ('AD01','tisatunrizafaa','tisa2003'),
			 ('AD02','yantinur','yanti2004');



DELIMITER //

-- Membuat trigger AFTER INSERT pada tabel pembelian
CREATE TRIGGER tambah_stok_pakaian_insert
AFTER INSERT ON pembelian
FOR EACH ROW
BEGIN
    IF (NEW.jumlah IS NOT NULL) THEN
        -- Menambahkan jumlah pembelian ke stok pakaian untuk INSERT
        UPDATE pakaian
        SET stok = stok + NEW.jumlah
        WHERE id_pakaian = NEW.id_pakaian;
    END IF;
END //

-- Membuat trigger AFTER UPDATE pada tabel pembelian
CREATE TRIGGER tambah_stok_pakaian_update
AFTER UPDATE ON pembelian
FOR EACH ROW
BEGIN
    IF (NEW.jumlah IS NOT NULL AND OLD.jumlah IS NOT NULL) THEN
        -- Mengurangkan jumlah pembelian lama dari stok pakaian untuk UPDATE
        UPDATE pakaian
        SET stok = stok - OLD.jumlah
        WHERE id_pakaian = NEW.id_pakaian;

        -- Menambahkan jumlah pembelian baru ke stok pakaian untuk  UPDATE
        UPDATE pakaian
        SET stok = stok + NEW.jumlah
        WHERE id_pakaian = NEW.id_pakaian;
    END IF;
END //



-- Membuat trigger AFTER DELETE pada tabel pembelian
CREATE TRIGGER kurangi_stok_pakaian_delete
AFTER DELETE ON pembelian
FOR EACH ROW
BEGIN
    IF (OLD.jumlah IS NOT NULL) THEN
        -- Mengurangkan jumlah pembelian yang dihapus dari stok pakaian untuk peristiwa DELETE
        UPDATE pakaian
        SET stok = stok - OLD.jumlah
        WHERE id_pakaian = OLD.id_pakaian;
    END IF;
END //

DELIMITER ;




DELIMITER //

-- Membuat trigger AFTER INSERT pada tabel penjualan
CREATE TRIGGER kurangi_stok_pakaian_insert
AFTER INSERT ON penjualan
FOR EACH ROW
BEGIN
    IF (NEW.jumlah IS NOT NULL) THEN
        -- Mengurangkan jumlah penjualan dari stok pakaian untuk peristiwa INSERT
        UPDATE pakaian
        SET stok = stok - NEW.jumlah
        WHERE id_pakaian = NEW.id_pakaian;
    END IF;
END //

-- Membuat trigger AFTER UPDATE pada tabel penjualan
CREATE TRIGGER update_stok_pakaian_update
AFTER UPDATE ON penjualan
FOR EACH ROW
BEGIN
    IF (NEW.jumlah IS NOT NULL AND OLD.jumlah IS NOT NULL) THEN
        -- Mengurangkan jumlah penjualan lama dari stok pakaian untuk peristiwa UPDATE
        UPDATE pakaian
        SET stok = stok + OLD.jumlah
        WHERE id_pakaian = NEW.id_pakaian;

        -- Menambahkan jumlah penjualan baru ke stok pakaian untuk peristiwa UPDATE
        UPDATE pakaian
        SET stok = stok - NEW.jumlah
        WHERE id_pakaian = NEW.id_pakaian;
    END IF;
END //

-- Membuat trigger AFTER DELETE pada tabel penjualan
CREATE TRIGGER tambah_stok_pakaian_delete
AFTER DELETE ON penjualan
FOR EACH ROW
BEGIN
    IF (OLD.jumlah IS NOT NULL) THEN
        -- Menambahkan jumlah penjualan yang dihapus ke stok pakaian untuk peristiwa DELETE
        UPDATE pakaian
        SET stok = stok + OLD.jumlah
        WHERE id_pakaian = OLD.id_pakaian;
    END IF;
END //

-- Mengembalikan delimiter ke semicolon
DELIMITER ;



