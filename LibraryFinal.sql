CREATE DATABASE db_LibraryFinal;

USE db_LibraryFinal
GO

/*-------------------------------------------------------------
                CREATE TABLES
-------------------------------------------------------------*/
CREATE PROCEDURE dbo.uspCreateTables
AS

CREATE TABLE tbl_publisher (
    publisher_ID INT PRIMARY KEY NOT NULL IDENTITY (1,1),
    publisher_Name VARCHAR(50), 
    publisher_Address VARCHAR(100) NOT NULL,
    publisher_Phone VARCHAR(15)
);

CREATE TABLE tbl_book (
    bk_BookID INT PRIMARY KEY NOT NULL IDENTITY (1,1),
    bk_Title VARCHAR(100) NOT NULL,
    bk_PublisherID INT NOT NULL CONSTRAINT fk_publisher_ID FOREIGN KEY REFERENCES tbl_publisher(publisher_ID) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tbl_bookAuthor (
     bkAuth_BookID INT NOT NULL CONSTRAINT fk_bk_BookID FOREIGN KEY REFERENCES tbl_book(bk_BookID) ON UPDATE CASCADE ON DELETE CASCADE,
     bkAuth_AuthorName VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_borrower (
    borrower_CardNo INT PRIMARY KEY NOT NULL IDENTITY (1000,1),
    borrower_Name VARCHAR(50) NOT NULL,
    borrower_Address VARCHAR (100) NOT NULL,
    borrower_Phone VARCHAR(15) NOT NULL
);

CREATE TABLE tbl_libraryBranch (
    libBrn_BranchID INT PRIMARY KEY NOT NULL IDENTITY (500,1),
    libBrn_BranchName VARCHAR(100) NOT NULL,
    libBrn_Address VARCHAR(100)
);

CREATE TABLE tbl_bookCopies (
    bkCopy_BookID INT NOT NULL CONSTRAINT fk_BookID FOREIGN kEY REFERENCES tbl_book(bk_BookID) ON UPDATE CASCADE ON DELETE CASCADE,
    bkCopy_BranchID INT NOT NULL CONSTRAINT fk_BranchID FOREIGN KEY REFERENCES tbl_libraryBranch(libBrn_BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
    bkCopy_NoOfCopies INT NOT NULL
);

CREATE TABLE tbl_bookLoans (
    bkLoan_BookID INT NOT NULL CONSTRAINT fk_BookLoanID FOREIGN kEY REFERENCES tbl_book(bk_BookID) ON UPDATE CASCADE ON DELETE CASCADE,
    bkLoan_BranchID INT NOT NULL CONSTRAINT fk_LoanBranchID FOREIGN KEY REFERENCES tbl_libraryBranch(libBrn_BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
    bkLoan_CardNo INT NOT NULL CONSTRAINT fk_CardNo FOREIGN KEY REFERENCES tbl_borrower(borrower_CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
    bkLoan_DateOut DATE NOT NULL,
    bkLoan_DueDate DATE NOT NULL,
   );
GO

/*-------------------------------------------------------------
                INSERT VALUES INTO TABLES
-------------------------------------------------------------*/
CREATE PROCEDURE dbo.uspInsertTables
AS

INSERT INTO tbl_publisher (publisher_Name, publisher_Address, publisher_Phone)
VALUES
('Picador USA','175 5th Ave, New York, NY','111-111-1111'),
('Random House','RandomHouse Tower New York, NY','222-222-2222'),
('Pocket Books','1230 Avenue of the Americas, Rockefeller Center, New York City, NY','333-333-3333'),
('Harper-Collins','195 Broadway, New York, NY','444-444-4444'),
('Scholastic','557 Broadway, New York, NY','555-555-5555'),
('Simon and Schuster','1230 6th Ave, New York, NY','666-666-6666'),
('Wiley','1807 New York City, NY','777-777-7777')
;

INSERT INTO tbl_book (bk_Title, bk_PublisherID)
VALUES
('The Lost Tribe',1),
('The Shining',2),
('Salem''s Lot',2),
('Cujo',3),
('Brave New World',4),
('Treasure Island',2),
('Harry Potter and the Sorceror''s Stone',5),
('Harry Potter and the Chamber of Secrets',5),
('Harry Potter and the Prisoner of Azkaban',5),
('Harry Potter and the Goblet of Fire',5),
('Harry Potter and the Order of the Phoenix',5),
('Harry Potter and the Half-Blood Prince',5),
('Harry Potter and the Deathly Hallows',5),
('Dante''s Inferno',2),
('Catch 22',6),
('Farenheit 451',6),
('Slaughterhouse 5',7),
('Cat''s Cradle',7),
('20,000 Leagues Under the Sea',4),
('The Count of Monte Cristo',4)
;

INSERT INTO tbl_bookAuthor (bkAuth_BookID, bkAuth_AuthorName)
VALUES
(1,'Mark Lee'),
(2,'Stephen King'),
(3,'Stephen King'),
(4,'Stephen King'),
(5,'Aldous Huxley'),
(6,'Robert Louis Stevenson'),
(7,'J.K. Rowling'),
(8,'J.K. Rowling'),
(9,'J.K. Rowling'),
(10,'J.K. Rowling'),
(11,'J.K. Rowling'),
(12,'J.K. Rowling'),
(13,'J.K. Rowling'),
(14,'Dante Alighieri'),
(15,'Joseph Heller'),
(16,'Ray Bradbury'),
(17,'Kurt Vonnegut'),
(18,'Kurt Vonnegut'),
(19,'Jules Verne'),
(20,'Alexandre Dumas')
;

INSERT INTO tbl_libraryBranch (libBrn_BranchName, libBrn_Address)
VALUES
('Sharpstown','123 Anywhere, Los Angeles, CA'),
('Central','111 Here, West Los Angeles, CA'),
('McKinley','222 There, Santa Monica, CA'),
('Watts','333 Far, Compton, CA')
;

INSERT INTO tbl_borrower (borrower_Name, borrower_Address, borrower_Phone)
VALUES

('Linda Brown','111 Main St','121-111-2222'),
('Larry Jones','222 4th Street','212-222-1111'),
('Mayhew Kalhi','333 7th Ave','323-333-2222'),
('Frank Burgess','444 Broadway Ave','434-333-4343'),
('Maria Pancetti','555 Circle St','545-555-4334'),
('Lyle Princhett','666 Denizen Way','656-666-5555'),
('Indy Patel','777 19th Ave','767-777-6666'),
('Kayley Durham','888 Triangle St','878-888-7777'),
('Lyssa White', '999 MeowMeow Ln', '999-999-9999')
;

INSERT INTO tbl_bookCopies (bkCopy_BookID, bkCopy_BranchID, bkCopy_NoOfCopies)
VALUES
(1,500,4),
(2,500,4),
(2,501,2),
(3,501,3),
(4,500,2),
(5,501,3),
(5,502,3),
(5,503,2),
(6,502,3),
(6,503,3),
(7,500,3),
(7,501,6),
(7,502,2),
(7,503,2),
(8,501,3),
(8,502,2),
(9,500,4),
(9,501,3),
(10,501,4),
(10,502,2),
(11,503,5),
(12,500,2),
(12,501,3),
(13,501,2),
(13,502,2),
(13,503,3),
(14,503,2),
(15,500,2),
(15,502,3),
(16,501,2),
(16,503,2),
(17,500,3),
(17,501,2),
(18,501,2),
(18,502,4),
(19,500,2),
(19,503,2),
(20,503,3),
(15,503,3),
(1,502,2),
(3,502,2)
;

INSERT INTO tbl_bookLoans (bkLoan_BookID, bkLoan_BranchID, bkLoan_CardNo, bkLoan_DateOut, bkLoan_DueDate)
VALUES
(2,500,1000,'2017-04-02','2017-04-20'),
(2,500,1001,'2017-04-05','2017-04-23'),
(2,501,1002,'2017-04-06','2017-04-24'),
(3,501,1002,'2017-04-06','2017-04-24'),
(3,501,1003,'2017-04-06','2017-04-24'),
(5,501,1003,'2017-04-06','2017-04-24'),
(6,500,1004,'2017-04-22','2017-05-16'),
(5,501,1000,'2017-04-08','2017-05-01'),
(5,502,1001,'2017-04-08','2017-05-01'),
(5,503,1005,'2017-04-10','2017-05-03'),
(5,503,1006,'2017-04-09','2017-05-02'),
(5,502,1007,'2017-04-13','2017-05-09'),
(6,502,1002,'2017-04-17','2017-05-05'),
(6,503,1000,'2017-04-21','2017-05-16'),
(7,500,1001,'2017-04-21','2017-05-16'),
(7,501,1002,'2017-05-01','2017-05-21'),
(7,501,1003,'2017-05-03','2017-05-24'),
(7,501,1004,'2017-05-06','2017-05-27'),
(7,502,1005,'2017-05-10','2017-05-30'),
(7,503,1006,'2017-05-12','2017-06-01'),
(8,501,1002,'2017-05-01','2017-05-21'),
(8,502,1005,'2017-05-10','2017-05-30'),
(9,500,1007,'2017-04-15','2017-05-02'),
(9,501,1002,'2017-04-21','2017-05-06'),
(10,501,1002,'2017-04-21','2017-05-06'),
(11,503,1002,'2017-04-29','2017-05-11'),
(12,501,1002,'2017-05-06','2017-05-22'),
(14,503,1003,'2017-05-02','2017-05-16'),
(15,500,1004,'2017-05-02','2017-05-16'),
(15,502,1005,'2017-05-03','2017-05-16'),
(15,502,1006,'2017-05-05','2017-05-19'),
(16,503,1003,'2017-05-02','2017-05-15'),
(17,501,1007,'2017-05-04','2017-05-17'),
(18,501,1007,'2017-05-04','2017-05-17'),
(18,502,1006,'2017-05-05','2017-05-19'),
(18,502,1000,'2017-05-09','2017-05-22'),
(19,500,1001,'2017-05-09','2017-05-22'),
(17,500,1001,'2017-05-09','2017-05-22'),
(19,503,1005,'2017-05-10','2017-05-24'),
(19,503,1003,'2017-05-02','2017-05-15'),
(19,500,1004,'2017-05-10','2017-05-24'),
(13,502,1002,'2017-05-10','2017-05-24'),
(20,503,1005,'2017-05-10','2017-05-24'),
(1,500,1007,'2017-05-12','2017-05-29'),
(1,500,1006,'2017-05-13','2017-05-30'),
(1,502,1002,'2017-05-13','2017-05-30'),
(1,500,1000,'2017-05-14','2017-06-01'),
(3,502,1003,'2017-05-14','2017-06-01'),
(3,502,1007,'2017-05-15','2017-06-02'),
(1,500,1000,'2017-02-02','2017-02-20')
;
GO

/*------------------------------------------
			DRILLS
-------------------------------------------*/

--DRILL 1
CREATE PROCEDURE dbo.uspLostTribeCopiesSharpstown
AS
SELECT bkCopy_NoOfCopies AS 'Number of Copies'
FROM tbl_bookCopies 
INNER JOIN tbl_book ON tbl_book.bk_BookID = tbl_bookCopies.bkCopy_BookID
INNER JOIN tbl_libraryBranch ON tbl_libraryBranch.libBrn_BranchID = tbl_bookCopies.bkCopy_BranchID
WHERE tbl_book.bk_Title = 'The Lost Tribe' AND tbl_libraryBranch.libBrn_BranchName = 'Sharpstown'
;
GO

--DRILL 2
CREATE PROCEDURE dbo.uspLostTribeCopiesPerBranch
AS
SELECT tbl_libraryBranch.libBrn_BranchName AS 'Library Branch', SUM(bkCopy_NoOfCopies) AS 'Number of Copies'
FROM tbl_bookCopies 
INNER JOIN tbl_book ON tbl_book.bk_BookID = tbl_bookCopies.bkCopy_BookID
INNER JOIN tbl_libraryBranch ON tbl_libraryBranch.libBrn_BranchID = tbl_bookCopies.bkCopy_BranchID
WHERE tbl_book.bk_Title = 'The Lost Tribe'
GROUP BY tbl_libraryBranch.libBrn_BranchName
;
GO

--DRILL 3
CREATE PROCEDURE dbo.uspNoCheckoutsExcept
AS
SELECT w.borrower_Name 
FROM tbl_borrower w
WHERE w.borrower_CardNo IN (
	SELECT w.borrower_CardNo
	FROM tbl_borrower w 
	EXCEPT
	SELECT DISTINCT l.bkLoan_CardNo
	FROM tbl_bookLoans l 
	)
;
GO

--DRILL 4
CREATE PROCEDURE dbo.uspDueTodaySharpstown
AS
SELECT b.bk_Title, w.borrower_Name, w.borrower_Address
FROM tbl_bookLoans l
INNER JOIN tbl_book b ON l.bkLoan_BookID = b.bk_BookID
INNER JOIN tbl_borrower w ON l.bkLoan_CardNo = w.borrower_CardNo
INNER JOIN tbl_libraryBranch r ON l.bkLoan_BranchID = r.libBrn_BranchID
WHERE r.libBrn_BranchName = 'Sharpstown' AND l.bkLoan_DueDate = CONVERT (date, GETDATE())
;
GO

--DRILL 5
CREATE PROCEDURE dbo.uspNumBooksLoanedPerBranch
AS
SELECT COUNT(l.bkLoan_BookID) AS 'Total Books Loaned', r.libBrn_BranchName
FROM tbl_bookLoans l
INNER JOIN tbl_libraryBranch r ON r.libBrn_BranchID = l.bkLoan_BranchID
GROUP BY r.libBrn_BranchName
;
GO

--DRILL 6
CREATE PROCEDURE dbo.uspMoreThan5CheckOutsNameAddress
AS
SELECT w. borrower_Name, w.borrower_Address, COUNT(l.bkLoan_BookID) AS 'Number of books loaned'
FROM tbl_borrower w 
INNER JOIN tbl_bookLoans l ON l.bkLoan_CardNo = w.borrower_CardNo
GROUP BY w.borrower_Name, w.borrower_Address
HAVING COUNT(l.bkloan_BookID) > 5 
;
GO

--DRILL 7
CREATE PROCEDURE dbo.uspNoCopiesSKingCentral
AS
SELECT b.bk_Title, c.bkCopy_NoOfCopies
FROM tbl_book b
INNER JOIN tbl_bookCopies c ON c.bkCopy_BookID = b.bk_BookID
INNER JOIN tbl_bookAuthor a ON a.bkAuth_BookID = b.bk_BookID
INNER JOIN tbl_libraryBranch r ON c.bkCopy_BranchID = r.libBrn_BranchID
WHERE a.bkAuth_AuthorName = 'Stephen King' AND r.libBrn_BranchName = 'Central'
;
GO
