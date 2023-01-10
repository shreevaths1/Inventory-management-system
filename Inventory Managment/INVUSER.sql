drop table invoice;
drop table purchase_order;
desc users;
desc product;
desc customer;
desc purchase_order;
desc invoice;
desc supplier;
desc sales;
create table users(
    user_id number GENERATED ALWAYS as IDENTITY START with 100 INCREMENT by 1 primary key,
    username varchar(20) not null,
    password varchar(20) not null,
    fullname varchar(30) not null,
    designation varchar(10) not null,
    contact int not null,
    account_type varchar(5) not null
);

create table product(
    product_id number GENERATED ALWAYS as IDENTITY START with 200 INCREMENT by 1 primary key,
    product_code varchar(25) not null,
    product_name varchar(50) not null,
    unit_name varchar(15) not null,
    unit_in_stock float not null,
    unit_price float not null,
    category varchar(25) not null,
    reorder_level float not null,
    user_id number not null references users(user_id)
);

create table customer(
    cust_id number GENERATED ALWAYS as IDENTITY START with 300 INCREMENT by 1 primary key,
    password varchar(25) not null,
    username varchar(50) not null,
    cust_name varchar(50) not null,
    contact int not null,
    address varchar(100) not null,
    email varchar(30) not null
);

create table invoice(
    invoice_id number GENERATED ALWAYS as IDENTITY START with 400 INCREMENT by 1 primary key,
    cust_id number not null references customer(cust_id),
    user_id number not null references users(user_id),
    product_id  number not null references product(product_id),
    payment_type varchar(15) not null,
    quantity float not null,
    total_amount float not null,
    bank_account_name varchar(50) not null,
    back_account_number varchar(25) not null,
    date_recorded date not null
);

create table supplier(
    supplier_id number GENERATED ALWAYS as IDENTITY START with 500 INCREMENT by 1 primary key,
    supplier_name varchar(50) not null,
    suppler_contact int not null,
    supplier_address varchar(100) not null,
    supplier_email varchar(50) not null
);

create table purchase_order(
    order_id number GENERATED ALWAYS as IDENTITY START with 600 INCREMENT by 1 primary key,
    product_id number not null references product(product_id),
    supplier_id number not null references supplier(supplier_id),
    user_id number not null references users(user_id),
    quantity float not null,
    unit_price float not null,
    sub_total float not null,
    order_date date not null,
    recieved_date date not null
);

insert into users(username,password,fullname,designation,contact,account_type) values('emp','emp','Ryan Reynolds','Employee',7890353767,'E');
insert into customer(password,username,cust_name,contact,address,email) values('raj123','raj','Rajshekar Rao',9876043219,
'#108,7th street,horamavu main road, banaswadi, bengaluru-560043','raj@gmail.com');
select * from users;
select * from customer;
