## Key Features

* A web api to allow users to be added, edited and deleted from a sql server db.

## How To: Run Migrations

To setup the DB you will need to run the Migrations (which are already setup), please confirm your local db connection string path and update it in the appsettings.json and appsettings.Development files. Open the Package Manager Console by clicking Tools > Nuget Package Manager > Package Manager Console, and Type the following command:

```bash
# Update Database
update-database
```