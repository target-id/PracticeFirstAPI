INSERT INTO books (title, author, genre, published_year, available)
VALUES 
('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction', 1925, 1),
('1984', 'George Orwell', 'Dystopia', 1949, 1),
('To Kill a Mockingbird', 'Harper Lee', 'Fiction', 1960, 0),
('Moby Dick', 'Herman Melville', 'Adventure', 1851, 1),
('War and Peace', 'Leo Tolstoy', 'Historical', 1869, 0);
GO

SELECT * FROM books;
GO