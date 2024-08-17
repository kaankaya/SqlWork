/*
 Sorular

Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.

Cevap:

SELECT * FROM film 
WHERE title LIKE '%n'
ORDER BY length DESC
LIMIT 5;




Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralayınız.

Cevap:
SELECT length FROM film 
WHERE title LIKE '%n'
ORDER BY length
OFFSET 1
LIMIT 5;


customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız.

Cevap: 

SELECT * FROM customer
WHERE store_id = 1
ORDER BY last_name DESC
LIMIT 4;

 */