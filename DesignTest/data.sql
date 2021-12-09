drop table [dbo].[booking];
drop table [dbo].[useer];
drop table [dbo].[route];

CREATE TABLE [dbo].[useer]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[username] NVARCHAR(50) NOT NULL UNIQUE,
	[password] NVARCHAR(50) NOT NULL,
	[name] NVARCHAR(50) NOT NULL,
	[address] NVARCHAR(50) NOT NULL,
	[email] NVARCHAR(50) NOT NULL,
	[phone] VARCHAR(11) NOT NULL,
)

create table [dbo].[route]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[from_city] NVARCHAR(50) NOT NULL,
	[to_city] NVARCHAR(50) NOT NULL,
	[km] INT NOT NULL,
	[when] DATETIME NOT NULL,
	[seats] INT NOT NULL,
)

create table [dbo].[booking]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[route_id] INT NOT NULL REFERENCES route(id),
	[user_id] INT NOT NULL REFERENCES useer(id),
	--[route_id] INT NOT NULL UNIQUE FOREIGN KEY(route_id) REFERENCES route(id) ON DELETE CASCADE,
	--[user_id] INT NOT NULL FOREIGN KEY(user_id) REFERENCES users(id) ON DELETE CASCADE,
)