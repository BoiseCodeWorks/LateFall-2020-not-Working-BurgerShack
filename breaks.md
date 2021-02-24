socket hangup - Navigate to https instead of http
in postman - ssl certification enabled
in appsettings - database connection is bad mysql4 => mysql5
-this means tables are missing for burgeringredient 
Startup - missing transient for repo
Burger model - paramaterless constructor missing from model
Burger Controller - missing using directive in Controller
Burger Controller -  is not extending controllerbase
Burger Repo - returning wrong type in Getall in repo (should be returning iEnumerable)
Burger Repo - returning Null in get by ID (no 'id' variable in Dapper method) add => new {ID}