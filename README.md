Prerequisite : 

--IN SQL SERVER : 
  CREATE TABLE hospital(
			ID INT IDENTITY(1,1),
			NAME VARCHAR(100),
			Cause VARCHAR(1000));

--CONFIG appsettings.json with 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=servername;Database=dbname;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
