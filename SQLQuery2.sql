--Select 
Select * from Customers --* klonla anlamına gelir

Select * from Customers where City = 'Berlin' --veritabından şehri Berlin olanları getir
--case insersitive (büyük küçük harf duyarsız)
select * from Products where CategoryID = 1 -- where koşulu olmaz ise hepsini gösterir

Select * from Products where CategoryID = 1 and UnitPrice >=10

select * from Products order by UnitPrice --order  by = sırala

select count(*) from Products --kaç tane olduğunu gösterir

 select categoryId , count(*) from products group by CategoryID --Hangi kategoride kaç farklı ürünümüz var ?

 select   categoryId , count(*) from products group by CategoryID having count(*)<10 --ürün sayısı 10 dan az olan kategorileri listele

 select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

 --DTO Data transformation object //  

 select * from Products inner join  [Order Details]  od on p.productId = od.ProductID

--inner join iki tabloda eşlesenleri getirir
--left join solda olup sağdan olmayanlarıda getirir(satış yapılmayan ürünler)
select * from Customers c left join orders o on c.CustomerID = o.CustomerID

 select * from Customers c left join orders o on c.CustomerID = o.CustomerID  where o.CustomerID  is null --sistemimize kayıtlı ama ürün almaya müşterileri getir



