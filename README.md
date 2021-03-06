# angularNorthwind
Angular frontend for the Northwind database and [Visual Studio 2015 Express](https://www.visualstudio.com/features/modern-web-tooling-vs).

[SQL Server Express 2015](https://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx) is also used. The Northwind SQL script does not support LocalDB so a local instance of SQL Server Express is required.

The project is primarily used as a reference as new technologies are learned and/or applied. In some cases, specific working examples will named per folders under AngularJS Single Page Apps (SPA). In other cases these examples will only be viewable within the code itself with sufficient comments (and occasional url references).

Ideally, this project will flow like a living and working tutorial for my own good pleasure. Often, many of the features that are highlighted were difficult to find on the Internet.

The Northwind database was selected because many "old school" Microsoft devlepers will be readily familiar with its structure. The backend data is not relevant other than to provide near real world complexity in a reasonably sized database.

### And So We Begin
1. Creating and initializing the project.
Create a standard ASP.NET Web Application with these features:
 * ASP.NET 4.5.2 Templates - Web API (v5 Templates initial release gave me some problems).
 * Add unit tests - not used initially but very important.
 * Authentication - "No Authentication" (will add later).
 * Microsoft Azure - not selected (hosted locally for reference purposes only).

2. Install the Northwind Database
 * I loosely followed the instructions here with some modifications noted: https://msdn.microsoft.com/en-us/library/8b6y4c7s(v=vs.120).aspx
 * Load the 'Northwind.sql' file from the project.
 * Right click the script or click the Connection icon to connect to a database.
    * Choose '(LocalDb)\MSSQLLocalDB' for the server name.
    * MSSQLLocalDB is the new name for the old (LocalDB)v11.0 connection string.
 * Now run the query by clicking the green arrow icon in the SQL toolbar.
    * This file was modified by commenting out lines 24 and 25 with an unknown stored procedure 'sp_dboption'.
    * Note - no MDB files are attached to this project. The databases must be created separately to run this project.
 * The table data can be reviewed from the SQL Server Object Explorer. The database files are actually stored per user under 'AppData' to mimic actual SQL Server instance data.
 * Note - This script can be rerun at any time to reinitialize the database to its original state.
  
3. Create the database model with EF6
 * Install the latest version of Entity Framework 6 via nuget (v6.1.3 at the time of writing).
    * You might also take this opportunity to update any other out of date packages.
 * Right click the 'Models' project folder and select 'Add' and 'New Item...'
 * Select 'Data' in the left pane and choose 'ADO.NET Entity Data Model'. Name the model 'Northwind'.
 * Select 'Code First from database' and click Next.
 * Click 'New Connection' (if the Northwind connection is available, just select it).
    * Enter 'machine\SQLEXPRESS' where machine is the name of the local computer.
    * Select the database name: Northwind
    * Click 'Test Connection' to verify settings and then OK.
 * Change the default connection entity name to 'Northwind' for the Web.Config file.
 * Choose all of the Northwind database tables by clicking the root 'Tables' item.
 * Click Finish to create the Northwind Entity Framework database model.
 * There should now be about 12 new files in the 'Models' folder that represent the Northwind database.

4. Adding support for AngularJS
  * Open nuget and search for 'angularjs' and install 'AngularJS.Core' (v1.4.8 as of this writing).
    * These files are generally written to the 'Scripts' folder. 
  * Also add 'AngularJS.Route' as this will be used with our SPA example (v1.4.8).

  
