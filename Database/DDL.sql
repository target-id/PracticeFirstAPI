-- 1. Crear la base de datos
CREATE DATABASE BookstoreDB;
GO

-- Usar la base de datos creada
USE BookstoreDB;
GO

-- 2. Crear la tabla 'books'
CREATE TABLE books (
    id INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(255) NOT NULL,
    author NVARCHAR(255) NOT NULL,
    genre NVARCHAR(100),
    published_year INT,
    available BIT
);
GO
