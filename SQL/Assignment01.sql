
insert into Customer values(1, 'Amruta', 'Kulkarni', 'Dhule', 'India', '8877991122' );
insert into Customer values(2, 'Bhakti', 'Takane', 'Amalner', 'India', '6677991133' );
insert into Customer values(3, 'Srishti', 'Patil', 'Dallas', 'America', '8877990092' );
insert into Customer values(4, 'Raksha', 'Gujrathi', 'seoul', 'Korea', '8876591122' );

Select * from Customer

Select Country from Customer
where Country like 'A%' OR Country like 'I%'
order by Country

select FirstName from Customer
where FirstName like '__i%'
