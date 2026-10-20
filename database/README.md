
# BookReviewHub Database

This folder contains a sample SQL Server database for the BookReviewHub application.

## Sample Database Export

File: [BookReviewHubDB_Updated.bacpac](BookReviewHubDB_Updated.bacpac)

The database contains:
- 25 sample books across five genres
- Book titles and authors
- Sample book reviews and star ratings

## How to Import the Database

1. Open SQL Server Management Studio (SSMS).
2. Connect to your SQL Server instance.
3. Right-click **Databases**.
4. Select **Import Data-tier Application**.
5. Choose `BookReviewHubDB_Updated.bacpac`.
6. Follow the wizard to import the database.
7. Update the application's connection string if necessary.

**Note:** This database contains demonstration data for portfolio purposes.

## Database Verification

The BACPAC file was successfully imported and tested using SQL Server Management Studio (SSMS) with SQL Server LocalDB.

The following records were verified:
- **25 books** across five genres
- **5 genres:** Fantasy, Science Fiction, Mystery, Romance, and Horror
- **3 sample reviews** with reviewer names, ratings, and comments

All three tables (Books, Genres, and Reviews) were checked using SQL SELECT queries.

**Result:** Database import and data verification completed successfully.
