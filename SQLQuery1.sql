SELECT Borrowed.borrowerId,Book.accession_number,Book.title,Book.author 
FROM Borrowed
INNER JOIN Book ON Book.accession_number = Borrowed.accession_number;