SELECT film.title, film.description from film

SELECT * FROM film WHERE film.rental_rate = 0.99 AND film.replacement_cost = 12.99 OR film.replacement_cost = 28.99

SELECT * from film WHERE length > 60 and length < 75 order by film_id

SELECT customer.last_name from customer where first_name = 'Mary'

SELECT * from film WHERE NOT length > 50 AND NOT rental_rate = 2.99 OR NOT rental_rate = 4.99