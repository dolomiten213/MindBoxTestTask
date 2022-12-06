create table products (id int, name text);

insert into products values
   (1, 'versace eros flame')
  ,(2, 'ram')
  ,(3, 'gpu')
  ,(4, 'motherboard')
  ,(5, 'dolce gabana the one')
  ,(6, 'fork')
  ,(7, 'aroma ssd')
;

create table categories (id int, name text);
insert into categories values
   (1, 'parfum')
  ,(2, 'pc')
;

create table products_categories (product_id int, category_id int);
insert into products_categories values
   (1, 1)
  ,(2, 2)
  ,(3, 2)
  ,(4, 2)
  ,(5, 1)
  ,(7, 1)
  ,(7, 2)
;

select products.name, categories.name from products
left join products_categories
on products.id = products_categories.product_id
left join categories
on categories.id = products_categories.category_id