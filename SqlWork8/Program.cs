/*
 
1-) test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

CREATE TABLE employee(
id SERIAL PRIMARY KEY,
name VARCHAR(50) NOT NULL,
birthday DATE,
email VARCHAR(100)
);





2-)Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
//verileden bir kaçtanesini ekledim buraya sadece sayısı fazla oldugu için
insert into employee (name, birthday, email) values ('Erv Warcup', '2015-05-03', 'ewarcup0@dropbox.com');
insert into employee (name, birthday, email) values ('Rowney Bowie', '1992-05-17', 'rbowie1@gmpg.org');
insert into employee (name, birthday, email) values ('Ailee Abadam', '1948-02-16', 'aabadam2@harvard.edu');
insert into employee (name, birthday, email) values ('Candide Repper', '1926-06-16', 'crepper3@umich.edu');
insert into employee (name, birthday, email) values ('Kristen Banat', '1983-02-15', 'kbanat4@blogs.com');
insert into employee (name, birthday, email) values ('Alley Cajkler', '1972-11-28', 'acajkler5@smugmug.com');
insert into employee (name, birthday, email) values ('Georgi Broadist', null, 'gbroadist6@live.com');
insert into employee (name, birthday, email) values ('Shayne Fielder', '1939-02-13', 'sfielder7@mlb.com');
insert into employee (name, birthday, email) values ('Elias Donnelly', '1998-08-08', 'edonnelly8@diigo.com');
insert into employee (name, birthday, email) values ('Gerhardt Birckmann', '1959-08-07', 'gbirckmann9@feedburner.com');
insert into employee (name, birthday, email) values ('Marion Berendsen', '1967-06-22', 'mberendsena@dedecms.com');
insert into employee (name, birthday, email) values ('Aurilia Restill', '1906-06-20', null);

3-)Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

UPDATE employee
SET 
	name = 'Guncel',
	email = 'guncel@guncel.com'
WHERE id = 6
RETURNING *;


Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
 
DELETE FROM employee
WHERE id = 6
RETURNING *;
 
 
 */