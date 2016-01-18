# angularNorthwind
Angular frontend for the Northwind database and [Visual Studio 2015 Express](https://www.visualstudio.com/features/modern-web-tooling-vs).

[SQL Server Express 2015](https://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx) is also used. The Northwind SQL script does not support LocalDB so a local instance of SQL Server Express is required.

The project is primarily used as a reference as new technologies are learned and/or applied. In some cases, specific working examples will named per folders under AngularJS Single Page Apps (SPA). In other cases these examples will only be viewable within the code itself with sufficient comments (and occasional url references).

Ideally, this project will flow like a living and working tutorial for my own good pleasure. Often, many of the features that are highlighted were difficult to find on the Internet.

The Northwind database was selected because many "old school" Microsoft devlepers will be readily familiar with its structure. The backend data is not relevant other than to provide near real world complexity in a reasonably sized database.

## And So We Begin
1. Creating and initializing the project.
Create a standard ASP.NET Web Application with these features:
* ASP.NET 4.5.2 Templates - Web API (v5 Templates initial release gave me some problems).
* Add unit tests - not used initially but very important.
* Authentication - "No Authentication" (will add later).
* Microsoft Azure - not selected (hosted locally for reference purposes only).

 2. Instal the Northwind Database
# I loosely followed the instructions here with some modifications noted: https://msdn.microsoft.com/en-us/library/8b6y4c7s(v=vs.120).aspx
# Load the 'Northwind.sql' file from the project.
# Connect to 
# Open SQL Server Object Explorer and select "(LocalDb)\MSSQLLocalDB (SQL Server 12.x.yyyy - machine\user" where 'machine' is the local computer name and 'user' is the local user name.
# Create a new SQL Query (right click server or hit icon).
