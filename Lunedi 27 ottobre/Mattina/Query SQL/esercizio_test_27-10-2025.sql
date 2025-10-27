CREATE DATABASE IF NOT EXISTS esercizio_test;

CREATE TABLE IF NOT EXISTS esercizio_test.Libri (
    id INT,
    titolo VARCHAR(100),
    autore VARCHAR(100),
    genere VARCHAR(50),
    anno_pubblicazione INT,
    prezzo DECIMAL(6, 2)
);

CREATE TABLE IF NOT EXISTS esercizio_test.Vendite (
    id INT,
    id_libro INT,
    data_vendite DATE,
    quantita INT,
    negozio VARCHAR(100)
);

INSERT INTO esercizio_test.Libri (id, titolo, autore, genere, anno_pubblicazione, prezzo)
VALUES
	(1, 'Il nome della rosa', 'Umberto Eco', 'Giallo storico', 1980, 12.90),
	(2, '1984', 'George Orwell', 'Distopico', 1949, 9.99),
	(3, 'Orgoglio e pregiudizio', 'Jane Austen', 'Romanzo', 1813, 8.50),
	(4, 'I promessi sposi', 'Alessandro Manzoni', 'Storico', 1840, 10.00),
	(5, 'Il signore degli anelli', 'J.R.R. Tolkien', 'Fantasy', 1954, 15.99),
	(6, 'Harry Potter e la pietra filosofale', 'J.K. Rowling', 'Fantasy', 1997, 11.50),
	(7, 'Il piccolo principe', 'Antoine de Saint-Exupéry', 'Favola', 1943, 7.80),
	(8, 'Moby Dick', 'Herman Melville', 'Avventura', 1851, 9.70),
	(9, 'Don Chisciotte', 'Miguel de Cervantes', 'Classico', 1605, 13.20),
	(10, 'La divina commedia', 'Dante Alighieri', 'Poema', 1320, 14.50),
	(11, 'Il grande Gatsby', 'F. Scott Fitzgerald', 'Romanzo', 1925, 10.90),
	(12, 'Cime tempestose', 'Emily Brontë', 'Romanzo', 1847, 8.90),
	(13, 'Dracula', 'Bram Stoker', 'Horror', 1897, 9.40),
	(14, 'Frankenstein', 'Mary Shelley', 'Horror', 1818, 8.60),
	(15, 'Il vecchio e il mare', 'Ernest Hemingway', 'Avventura', 1952, 7.90),
	(16, 'Il ritratto di Dorian Gray', 'Oscar Wilde', 'Romanzo', 1890, 9.20),
	(17, 'Guerra e pace', 'Lev Tolstoj', 'Storico', 1869, 13.80),
	(18, 'Anna Karenina', 'Lev Tolstoj', 'Romanzo', 1877, 12.50),
	(19, 'Fahrenheit 451', 'Ray Bradbury', 'Distopico', 1953, 10.50),
	(20, 'Il codice da Vinci', 'Dan Brown', 'Thriller', 2003, 12.40),
	(21, 'Lo Hobbit', 'J.R.R. Tolkien', 'Fantasy', 1937, 11.80),
	(22, 'Le cronache di Narnia', 'C.S. Lewis', 'Fantasy', 1950, 13.00),
	(23, 'Sherlock Holmes', 'Arthur Conan Doyle', 'Giallo', 1892, 9.60),
	(24, 'Il processo', 'Franz Kafka', 'Romanzo', 1925, 9.80),
	(25, 'Cent’anni di solitudine', 'Gabriel García Márquez', 'Magico', 1967, 12.30),
	(26, 'Il lupo della steppa', 'Hermann Hesse', 'Romanzo', 1927, 10.10),
	(27, 'Siddharta', 'Hermann Hesse', 'Spirituale', 1922, 8.70),
	(28, 'La coscienza di Zeno', 'Italo Svevo', 'Romanzo', 1923, 9.00),
	(29, 'L’isola del tesoro', 'Robert L. Stevenson', 'Avventura', 1883, 8.40),
	(30, 'Il giovane Holden', 'J.D. Salinger', 'Romanzo', 1951, 9.50),
    (31, 'La ragazza del treno', 'Paula Hawkins', 'Thriller', 2015, 11.90),
	(32, 'L’amica geniale', 'Elena Ferrante', 'Narrativa', 2011, 13.50),
	(33, 'Uomini che odiano le donne', 'Stieg Larsson', 'Giallo', 2005, 12.80),
	(34, 'Inferno', 'Dan Brown', 'Thriller', 2013, 14.20),
	(35, 'La strada', 'Cormac McCarthy', 'Distopico', 2006, 10.70),
	(36, 'Il cacciatore di aquiloni', 'Khaled Hosseini', 'Drammatico', 2003, 11.40),
	(37, 'La verità sul caso Harry Quebert', 'Joël Dicker', 'Giallo', 2012, 13.10),
	(38, 'Non è un paese per vecchi', 'Cormac McCarthy', 'Thriller', 2005, 9.90),
	(39, 'Il bambino con il pigiama a righe', 'John Boyne', 'Drammatico', 2006, 8.80),
	(40, 'Eleanor Oliphant sta benissimo', 'Gail Honeyman', 'Narrativa', 2017, 12.30),
    (41, 'It', 'Stephen King', 'Horror', 1986, 14.90),
	(42, 'Shining', 'Stephen King', 'Horror', 1977, 13.50),
	(43, 'Misery', 'Stephen King', 'Thriller', 1987, 12.80),
	(44, 'Carrie', 'Stephen King', 'Horror', 1974, 11.20);

INSERT INTO esercizio_test.Vendite (id, id_libro, data_vendite, quantita, negozio)
VALUES
	(1, 1, '2024-01-10', 3, 'Libreria Centrale'),
	(2, 2, '2024-02-12', 2, 'BookWorld'),
	(3, 3, '2024-02-20', 1, 'Mondolibri'),
	(4, 4, '2024-03-01', 5, 'Feltrinelli'),
	(5, 5, '2024-03-15', 2, 'Giunti al Punto'),
	(6, 6, '2024-04-02', 4, 'BookWorld'),
	(7, 7, '2024-04-18', 3, 'Libreria Centrale'),
	(8, 8, '2024-05-05', 1, 'Feltrinelli'),
	(9, 9, '2024-05-19', 2, 'Mondolibri'),
	(10, 10, '2024-06-01', 6, 'Libreria del Corso'),
	(11, 11, '2024-06-10', 3, 'BookWorld'),
	(12, 12, '2024-06-22', 2, 'Giunti al Punto'),
	(13, 13, '2024-07-03', 4, 'Feltrinelli'),
	(14, 14, '2024-07-11', 1, 'Libreria Centrale'),
	(15, 15, '2024-07-25', 3, 'BookWorld'),
	(16, 16, '2024-08-05', 2, 'Mondolibri'),
	(17, 17, '2024-08-18', 5, 'Libreria del Corso'),
	(18, 18, '2024-09-01', 3, 'Feltrinelli'),
	(19, 19, '2024-09-15', 2, 'Giunti al Punto'),
	(20, 20, '2024-09-30', 4, 'BookWorld'),
	(21, 21, '2024-10-10', 2, 'Libreria Centrale'),
	(22, 22, '2024-10-20', 3, 'Mondolibri'),
	(23, 23, '2024-11-05', 2, 'Giunti al Punto'),
	(24, 24, '2024-11-20', 1, 'Feltrinelli'),
	(25, 25, '2024-12-02', 3, 'BookWorld'),
	(26, 26, '2025-01-15', 2, 'Libreria Centrale'),
	(27, 27, '2025-02-01', 4, 'Giunti al Punto'),
	(28, 28, '2025-03-10', 3, 'Mondolibri'),
	(29, 29, '2025-04-05', 5, 'Feltrinelli'),
	(30, 30, '2025-05-01', 2, 'Libreria del Corso'),
    (31, 41, '2025-06-10', 3, 'Feltrinelli'),
	(32, 42, '2025-07-15', 2, 'BookWorld'),
	(33, 43, '2025-08-05', 4, 'Libreria Centrale'),
	(34, 44, '2025-09-01', 1, 'Giunti al Punto'),
    (35, 999, '2021-06-15', 2, 'BookWorld'),
    (36, 998, '2024-06-15', 5, 'BookWorld');

SELECT * FROM libri;
SELECT * FROM vendite;

-- Esercizio 1
SELECT
	libri.titolo AS Titolo,
    libri.autore AS Autore,
    vendite.data_vendite AS DataDiVendita,
    vendite.negozio AS Negozio
FROM esercizio_test.libri AS Libri
INNER JOIN esercizio_test.vendite AS Vendite
	ON libri.id = vendite.id_libro
WHERE LOWER(libri.autore) LIKE '%king%';

-- Esercizio 2
SELECT
    Libri.titolo AS Titolo,
    Libri.anno_pubblicazione AS AnnoPubblicazione,
    Libri.prezzo AS Prezzo,
    Vendite.data_vendite AS DataVendita
FROM esercizio_test.Libri AS Libri
LEFT JOIN esercizio_test.Vendite AS Vendite
	ON Libri.id = Vendite.id_libro
WHERE Libri.anno_pubblicazione BETWEEN 2000 AND 2010;

-- Esercizio 3
SELECT
    Libri.titolo AS Titolo,
    Vendite.negozio AS Negozio,
    Vendite.quantita AS Quantita,
    (Vendite.quantita * Libri.prezzo) AS PrezzoTotale
FROM esercizio_test.Libri AS Libri
INNER JOIN esercizio_test.Vendite AS Vendite
    ON Libri.id = Vendite.id_libro
WHERE Vendite.negozio IN ('Libreria Centrale', 'BookWorld', 'Feltrinelli');

-- Esercizio 4
SELECT
    Libri.titolo AS Titolo,
    Vendite.data_vendite AS DataVendita,
    Libri.prezzo AS Prezzo,
    Vendite.quantita AS Quantita
FROM esercizio_test.Vendite AS Vendite
LEFT JOIN esercizio_test.Libri AS Libri
    ON Vendite.id_libro = Libri.id
WHERE Vendite.data_vendite BETWEEN '2024-01-01' AND '2025-12-31'
  AND LOWER(Vendite.negozio) LIKE '%book%';