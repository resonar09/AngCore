# AngCore
Installation instructions
1. <browse> https://github.com/resonar09/AngCore
2. Open New VS Code Window and Open folder such as C:\Projects\Templates
3. Click Terminal-> New Terminal
4. <run> C:\Projects\Templates>git clone https://github.com/resonar09/AngCore
5. Click File Open Folder C:\Projects\Templates\AngCore
6. Click Terminal-> New Terminal
7. <run> C:\Projects\Templates\AngCore> cd AngCore.API
8. <run> C:\Projects\Templates\AngCore\AngCore.API> dotnet ef database update
9. Go to https://sqlitebrowser.org/dl/ and download to see the AngCore.db database
10. <run> C:\Projects\TEST\AngCore> cd AngCore-SPA
11. <run> C:\Projects\TEST\AngCore\AngCore-SPA> npm install
12. <run> C:\Projects\TEST\AngCore\AngCore-SPA> ng serve
13  <browse> http://localhost:4200/


Things I would like to Add to the App
1. Entity Models and DTO Models
2. Services and Repositories
3. Exception Handling (try/catches)
4. Versioning
5. Logging
6. AutoMapper to map Entities to DTOs
7. Swagger to Document