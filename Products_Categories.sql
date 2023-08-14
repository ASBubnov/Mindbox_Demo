-- ddl
create table products
(
    id   int identity(1,1) primary key,
    name varchar(255)
);
create table categories
(
    id   int identity(1,1) primary key,
    name varchar(50)
);

create table products_categories
(
    product_id  int foreign key references products(id),
    category_id int foreign key references categories(id)
);


-- dml
insert into products
values ('cheese'),
       ('milk'),
       ('plastic bag'),
       ('sausage'),
       ('snacks');

select *
from products;

insert into categories
values ('food'),
       ('drink'),
       ('milk products'),
       ('meet products');

select *
from categories;

insert into products_categories (product_id, category_id)
values (1, 1),
       (1, 3),
       (2, 1),
       (2, 3),
       (4, 1),
       (4, 4),
       (5, 1);

select *
from products_categories;

select p.name,
       c.name
from products p
         left join products_categories pc
                   on p.id = pc.product_id
         left join categories c
                   on pc.category_id = c.id;