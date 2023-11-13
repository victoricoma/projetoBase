create table categories(
	id int identity primary key,
	name varchar(100) not null
);

create table products(
	id int identity primary key,
	category_id int not null,
	name varchar(100) not null,
	description varchar(250) not null,
	price decimal(10,2) not null,
	stock int not null,
	image varchar(250),
	foreign key (category_id) references categories(id)
);

select *  from products;