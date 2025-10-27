CREATE DATABASE clienti_ordini;

CREATE TABLE clienti(
	id INT,
    nome VARCHAR(100),
    citta VARCHAR(100)
);

CREATE TABLE ordini(
	id INT,
    id_cliente INT,
    data_ordine DATE,
    importo DECIMAL(7, 2)
);

INSERT INTO Clienti
VALUES
	(1, 'Mario Rossi', 'Roma'),
	(2, 'Luca Bianchi', 'Milano'),
	(3, 'Maria Verdi', 'Napoli'),
	(4, 'Francesca Neri', 'Torino'),
	(5, 'Paolo Conti', 'Firenze'),
	(6, 'Anna Gallo', 'Bologna'),
	(7, 'Marco De Luca', 'Genova'),
	(8, 'Sara Esposito', 'Venezia'),
	(9, 'Davide Romano', 'Bari'),
	(10, 'Elena Greco', 'Verona'),
	(11, 'Stefano Ricci', 'Palermo'),
	(12, 'Chiara Moretti', 'Catania'),
	(13, 'Federico Marchetti', 'Trieste'),
	(14, 'Laura Fontana', 'Perugia'),
	(15, 'Simone Ferri', 'Salerno'),
	(16, 'Martina Costa', 'Padova'),
	(17, 'Costanzo Leone', 'Modena'),
	(18, 'Alessia Vitale', 'Pescara'),
	(19, 'Lorenzo Riva', 'Parma'),
	(20, 'Ilaria De Santis', 'Reggio Calabria');

INSERT INTO Ordini
VALUES
	(1, 1, '2025-01-15', 250.50),
	(2, 1, '2025-03-10', 120.00),
	(3, 2, '2025-02-20', 499.99),
	(4, 3, '2025-04-05', 89.90),
	(5, 4, '2025-05-12', 145.75),
	(6, 5, '2025-03-22', 320.00),
	(7, 6, '2025-02-08', 78.50),
	(8, 6, '2025-06-10', 210.25),
	(9, 7, '2025-01-29', 134.99),
	(10, 8, '2025-03-16', 560.00),
	(11, 9, '2025-07-02', 75.25),
	(12, 10, '2025-04-18', 199.00),
	(13, 11, '2025-08-11', 85.90),
	(14, 12, '2025-09-01', 340.00),
	(15, 13, '2025-03-03', 124.50),
	(16, 14, '2025-02-27', 412.80),
	(17, 15, '2025-06-15', 275.60),
	(18, 16, '2025-07-20', 98.75),
	(19, 17, '2025-05-30', 180.40),
	(20, 18, '2025-08-25', 650.00),
    (21, 21, '2025-08-25', 700.00);

SELECT * FROM clienti;
SELECT * FROM ordini;

/* INNER JOIN: Visualizza l'elenco dei clienti che hanno effettuato almeno un ordine
Per ciascuno, mostra: nome del cliente, data dell'ordine e importo */
SELECT
	clienti.nome,
    ordini.data_ordine,
    ordini.importo
FROM clienti
INNER JOIN ordini
ON clienti.id = ordini.id_cliente;

/* LEFT JOIN: Visualizza tutti i clienti, compresi quelli che non hanno effettuato ordini
Per ciascuno, mostra: nome cliente, data (se presente), importo (se presente) */
SELECT
	clienti.nome,
    ordini.data_ordine,
    ordini.importo
FROM clienti
LEFT JOIN ordini
ON clienti.id = ordini.id_cliente;

/* RIGHT JOIN: Visualizza tutti gli ordini,
anche quelli che non hanno un cliente associato
Per ciascuno, mostra: nome cliente (se esiste), data, importo */
SELECT
	clienti.nome,
    ordini.data_ordine,
    ordini.importo
FROM clienti
RIGHT JOIN ordini
ON clienti.id = ordini.id_cliente;