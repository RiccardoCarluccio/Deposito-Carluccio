/* Uso lo stesso db e tabelle dell'esercizio precedente: "clienti_e_ordini_JOIN"
quindi non farò CREATE DB, CREATE TABLE e INSERT INTO */

SELECT * FROM clienti;
SELECT * FROM ordini;

/* Elenca i clienti attivi, cioè quelli che hanno effettuato almeno un ordine, mostrando per ciascuno:
nome del cliente, totale ordini effettuati, somma totale degli importi spesi */
SELECT
	clienti.nome AS NomeCliente,
    COUNT(ordini.id) AS TotaleOrdini,
    SUM(ordini.importo) AS ImportoTotale
FROM clienti
INNER JOIN ordini
ON clienti.id = ordini.id_cliente
GROUP BY clienti.id, clienti.nome;

/* Elenca i clienti che non hanno mai effettuato ordini, mostrando solo:
nome del cliente, città di residenza */
SELECT
	clienti.nome AS NomeCliente,
    clienti.citta AS Citta
FROM clienti
LEFT JOIN ordini
ON clienti.id = ordini.id_cliente
WHERE ordini.id_cliente IS NULL;