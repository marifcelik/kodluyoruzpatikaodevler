SELECT * FROM country WHERE country LIKE 'A%a'

SELECT * FROM country WHERE country ~~ '______n'

SELECT * FROM film WHERE title ILIKE 't%t%t%T%'

SELECT * FROM film WHERE title ~~ 'C%' AND length > 90 AND rental_rate = 2.99