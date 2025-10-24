CREATE DATABASE mercato;

CREATE TABLE mercato.Vendite (
	id INT,
	prodotto VARCHAR(100),
	categoria VARCHAR(50),
	quantita INT,
	prezzo_unitario DECIMAL(6,2),
	data_vendita DATE
);

INSERT INTO mercato.Vendite
VALUES
	(1, 'Laptop X100', 'Elettronica', 5, 899.99, '2025-10-01'),
	(2, 'Smartphone S21', 'Elettronica', 10, 499.50, '2025-10-02'),
	(3, 'Tavolo in legno', 'Arredamento', 3, 150.00, '2025-10-03'),
	(4, 'Sedia Comfort', 'Arredamento', 7, 75.25, '2025-10-04'),
	(5, 'Lampada LED', 'Illuminazione', 12, 20.99, '2025-10-05'),
	(6, 'Penna Stilografica', 'Cancelleria', 50, 5.50, '2025-10-06'),
	(7, 'Quaderno A4', 'Cancelleria', 30, 2.80, '2025-10-07'),
	(8, 'Monitor 24"', 'Elettronica', 4, 199.99, '2025-10-08'),
	(9, 'Mouse Wireless', 'Elettronica', 15, 25.75, '2025-10-09'),
	(10, 'Tappeto Salotto', 'Arredamento', 2, 120.00, '2025-10-10'),
	(11, 'Cuscino Decorativo', 'Arredamento', 8, 18.50, '2025-10-11'),
	(12, 'Torcia Ricaricabile', 'Illuminazione', 6, 15.99, '2025-10-12'),
	(13, 'Cartuccia Stampante', 'Cancelleria', 20, 12.30, '2025-10-13'),
	(14, 'Hard Disk 1TB', 'Elettronica', 7, 75.00, '2025-10-14'),
	(15, 'Notebook Premium', 'Elettronica', 3, 1200.00, '2025-10-15'),
	(16, 'Lampadario Moderno', 'Illuminazione', 1, 250.00, '2025-10-16'),
	(17, 'Zaino Scuola', 'Accessori', 25, 35.00, '2025-10-17'),
	(18, 'Orologio da Polso', 'Accessori', 10, 85.99, '2025-10-18'),
	(19, 'Portapenne da Scrivania', 'Cancelleria', 15, 9.50, '2025-10-19'),
	(20, 'Stampante Laser', 'Elettronica', 2, 350.00, '2025-10-20');

SELECT * FROM vendite;

-- Totale vendite per categoria
SELECT categoria, COUNT(*) As TotaleVendite
FROM vendite
GROUP BY categoria;

-- Prezzo medio per categoria
SELECT categoria, AVG(prezzo_unitario) AS PrezzoMedio
FROM vendite
GROUP BY categoria;

-- Quantità venduta per ogni prodotto
SELECT prodotto, quantita
FROM vendite;

-- Quantità venduta di tutti i prodotti
SELECT SUM(quantita) AS QuantitaTotale
FROM vendite;

-- Quantità venduta per categoria
SELECT categoria, SUM(quantita) AS QuantitaVenduta
FROM vendite
GROUP BY categoria;

-- Prezzo massimo e minimo venduto nella tabella
SELECT prodotto, prezzo_unitario
FROM vendite
WHERE prezzo_unitario = (SELECT MAX(prezzo_unitario) AS PrezzoMassimo FROM vendite)
OR prezzo_unitario = (SELECT MIN(prezzo_unitario) AS PrezzoMinimo FROM vendite);

-- Numero totale di righe nella tabella
SELECT COUNT(*) FROM vendite;

-- I 5 prodotti più costosi
SELECT prodotto, prezzo_unitario
FROM vendite
ORDER BY prezzo_unitario DESC
LIMIT 5;

-- I 3 prodotti meno venduti
SELECT prodotto, quantita
FROM vendite
ORDER BY quantita ASC
LIMIT 3;

-- Guadagno totale per categoria
SELECT categoria, SUM(prezzo_unitario * quantita) AS PrezzoTotale
FROM vendite
GROUP BY categoria;

-- Guadagno medio per categoria
SELECT categoria, AVG(prezzo_unitario * quantita) AS PrezzoMedio
FROM vendite
GROUP BY categoria;