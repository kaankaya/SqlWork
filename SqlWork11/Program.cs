﻿/*
            SORULAR

1-)actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.

(
SELECT first_name
FROM actor
)
UNION
(
SELECT first_name
FROM customer
ORDER BY first_name
);
2-)actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
(
SELECT first_name
FROM actor
)
INTERSECT
(
SELECT first_name
FROM customer
ORDER BY first_name
);

3-)actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.

(
SELECT first_name
FROM actor
)
EXCEPT
(
SELECT first_name
FROM customer
ORDER BY first_name
);


4-)İlk 3 sorguyu tekrar eden veriler için de yapalım.


(
SELECT first_name
FROM actor
)
UNION ALL
(
SELECT first_name
FROM customer
ORDER BY first_name
);


2-)
SELECT first_name
FROM actor
WHERE first_name IN (SELECT first_name FROM customer)
ORDER BY first_name;

3-)
 SELECT actor.first_name FROM actor
LEFT JOIN customer ON actor.first_name = customer.first_name
WHERE customer.first_name IS NULL
ORDER BY first_name;

 
 */