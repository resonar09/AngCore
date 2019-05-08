# AngCore
Installation instructions
1. <browse> https://github.com/resonar09/AngCore
2. Open New VS Code Window and Open folder such as C:\Projects\Templates
3. Click Terminal-> New Terminal
4. <run> C:\Projects\TEST>git clone https://github.com/resonar09/AngCore
5. Click File Open Folder C:\Projects\Templates\AngCore
6. Click Terminal-> New Terminal
7. <run> C:\Projects\TEST\AngCore> cd AngCore.API
8. <run> C:\Projects\TEST\AngCore\AngCore.API> dotnet ef database update
9. Go to https://sqlitebrowser.org/dl/ and download to see the AngCore.db database
10. <run> C:\Projects\TEST\AngCore\AngCore.API> dotnet watch run
11. <run> C:\Projects\TEST\AngCore> cd AngCore-SPA
12. <run> C:\Projects\TEST\AngCore\AngCore-SPA> npm install
13. <run> C:\Projects\TEST\AngCore\AngCore-SPA> ng serve
14. <browse> http://localhost:4200/

Testing the Web API Core service
SELECT ALL - Get http://localhost:5000/api/todos/
SELECT By ID - Get http://localhost:5000/api/todos/2
INSERT NEW - Post http://localhost:5000/api/todos 
        HEADER
        Key: Content-Type  Value: application/json
        JSON BODY 
        {
            "name": "Take the trash out",
            "description": "Take the trash out",
            "completed": false
        }
UPDATE - Put http://localhost:5000/api/todos/2
        HEADER
        Key: Content-Type  Value: application/json
        JSON BODY 
        {
            "name": "Take the trash out again",
            "description": "Take the trash out again",
            "completed": false
        }
DELETE - Delete http://localhost:5000/api/todos/3

Things I would like to Add to the App
1. Entity Models and DTO Models
2. Services and Repositories
3. Exception Handling (try/catches)
4. Versioning
5. Logging
6. AutoMapper to map Entities to DTOs
7. Swagger to Document
