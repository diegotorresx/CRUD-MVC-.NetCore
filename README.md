Intrucciones para la ejecución del crud en .Net Core 6.0 MVC

1. Ejecutar todos los queries en su servidor de SQL Server empezando por el que crea la base de datos (CreateDatabase.sql), luego los queries que crean las tablas (CreateGirosTable.sql,CreatePaisesTable.sql,CreateCiudadesTable.sql, Create_Table_Pais_Selected.sql) y luego el resto que corresponden a los Stored procedures

2. Asegurarse de ejecutar todos los queries de creaciónd e stored procedure y de creación de base de datos y tablas.

3. en la solución del proyecto buscar el archivo appsettings.json y en su campo "CadenaSQL" modificar los valores de la cadena de conección modificando el Data Source segun su servidor, Catalog según su base de datos y user,id según sus credenciales

4. Se desarrollo la prueba con .NET Core 6.0 con el patrón de diseño MVC