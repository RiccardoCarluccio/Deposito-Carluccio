SELECT DISTINCT Region FROM country WHERE Continent = 'Europe';

SELECT Name, Population
FROM city
WHERE CountryCode = 'USA' AND Population > 1000000
ORDER BY Population DESC;

SELECT
	Continent,
    COUNT(*) As NumCountries,
    SUM(Population) as TotalPopulation
FROM country
GROUP BY Continent
ORDER BY TotalPopulation DESC;