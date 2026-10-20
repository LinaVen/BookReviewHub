
# BookReviewHub Database

This folder contains a sample SQL Server database for the BookReviewHub application.

## Database Backup

File: [BookReviewHubDB_Updated.bacpac](BookReviewHubDB_Updated.bacpac)

The database contains:
- 25 sample books across five genres
- Book titles and authors
- Sample book reviews and star ratings

## How to Restore the Database

1. Open SQL Server Management Studio (SSMS).
2. Connect to your SQL Server instance.
3. Right-click **Databases**.
4. Select **Import Data-tier Application**.
5. Choose `BookReviewHubDB_Updated.bacpac`.
6. Follow the wizard to import the database.
7. Update the application's connection string if necessary.

**Note:** This database contains demonstration data for portfolio purposes.
