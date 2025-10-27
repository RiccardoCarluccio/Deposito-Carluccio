CREATE DATABASE mercato_2;

CREATE TABLE mercato_2.clienti (
    id INT,
    nome VARCHAR(100),
    cognome VARCHAR(100),
    email VARCHAR(100),
    eta INT,
    citta VARCHAR(100)
);

INSERT INTO clienti
VALUES
	(1, 'Andrea', 'Rossi', 'andrea.rossi@gmail.com', 35, 'Roma'),
	(2, 'Luca', 'Bianchi', 'luca.bianchi@yahoo.com', 28, 'Milano'),
	(3, 'Alessia', 'Verdi', 'alessia.verdi@gmail.com', 31, 'Firenze'),
	(4, 'Marco', 'Conti', 'marco.conti@outlook.com', 42, 'Napoli'),
	(5, 'Anna', 'Neri', 'anna.neri@gmail.com', 39, 'Torino'),
	(6, 'Domenico', 'Colle', 'domenico.colle@gmail.com', 25, 'Bologna'),
	(7, 'Paola', 'Fonti', 'paola.fonti@hotmail.com', 33, 'Roma'),
	(8, 'Francesca', 'Rizzi', 'francesca.rizzi@gmail.com', 30, 'Verona'),
	(9, 'Matteo', 'Greco', 'matteo.greco@gmail.com', 45, 'Palermo'),
	(10, 'Alberto', 'Costa', 'alberto.costa@gmail.com', 37, 'Cagliari'),
	(11, 'Martina', 'Ferri', 'martina.ferri@yahoo.com', 26, 'Perugia'),
	(12, 'Davide', 'Serra', 'davide.serra@gmail.com', 32, 'Roma'),
	(13, 'Simona', 'Marra', 'simona.marra@libero.it', 41, 'Catanzaro'),
	(14, 'Arianna', 'Vitto', 'arianna.vitto@gmail.com', 29, 'Roma Nord'),
	(15, 'Stefano', 'Russo', 'stefano.russo@gmail.com', 34, 'Padova'),
	(16, 'Chiara', 'Leone', 'chiara.leone@gmail.com', 27, 'Roma Sud'),
	(17, 'Alessandro', 'Pace', 'alessandro.pace@gmail.com', 38, 'Rimini'),
	(18, 'Elena', 'More', 'elena.more@icloud.com', 24, 'Ancona'),
	(19, 'Antonio', 'Santi', 'antonio.santi@gmail.com', 40, 'Roma Centro'),
	(20, 'Valentina', 'Gallo', 'valentina.gallo@gmail.com', 36, 'Genova');
    
SELECT * FROM clienti;

-- Clienti con email che termina in '@gmail.com'
SELECT * FROM clienti
WHERE email LIKE '%@gmail.com';

-- Clienti con nome che inizia per 'A'
SELECT * FROM clienti
WHERE nome LIKE 'A%';

-- Clienti con cognome con lunghezza di 5 caratteri
SELECT * FROM clienti
WHERE LENGTH(cognome) = 5;

-- Clienti con età compresa tra i 30 e i 40 anni
SELECT * FROM clienti
WHERE eta BETWEEN 30 AND 40;

-- Clienti che vivono in città il cui nome contiene 'Roma' (case insensitive)
SELECT * FROM clienti
WHERE LOWER(citta) LIKE '%roma%';