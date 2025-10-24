CREATE DATABASE libreria;

CREATE TABLE libreria.libri (
	id INT PRIMARY KEY,
    titolo VARCHAR(100),
    autore VARCHAR(100),
    genere VARCHAR(50),
    prezzo DECIMAL(5,2),
    anno_pubblicazione INT
);

INSERT INTO libri
VALUES
	(1, 'Titolo 1', 'Autore 1', 'Genere 1', 20.5, 2000),
    (2, 'Titolo 2', 'Autore 2', 'Genere 2', 20.5, 2001),
    (3, 'Titolo 3', 'Autore 3', 'Genere 3', 20.5, 2002),
    (4, 'Titolo 4', 'Autore 4', 'Genere 4', 15, 2003),
    (5, 'Titolo 5', 'Autore 5', 'Genere 5', 25, 2004),
    (6, 'Titolo 6', 'Autore 6', 'Genere 6', 15, 2005),
    (7, 'Titolo 7', 'Autore 7', 'Genere 6', 20, 2006),
	(8, 'Titolo 8', 'Autore 8', 'Genere 7', 20, 2011),
	(9, 'Titolo 9', 'Autore 9', 'Genere 8', 20, 2012),
    (10, 'Titolo 10', 'Autore 10', 'Genere 10', 25, 2012),
	(11, 'Titolo 11', 'Autore 11', 'Genere 11', 25, 2013);
    
SELECT * FROM libri;

SELECT
	Genere,
    COUNT(*) as NumeroLibri,
    AVG(prezzo) as PrezzoMedio
FROM libri
GROUP BY Genere
ORDER BY genere ASC;
    
SELECT *
FROM libri
WHERE anno_pubblicazione > 2010
ORDER BY anno_pubblicazione DESC, prezzo ASC;