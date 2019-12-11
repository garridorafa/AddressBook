CREATE DATABASE addressbook;

USE addressbook;

CREATE TABLE contactslist (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(40),
    cellphone VARCHAR(14),
    email VARCHAR (30)
);