**Solution** : microServiceSLN

**Services** :

- Message.api
- Person.api

**Gateway** :

- microServiceSLN.Desktop.Gateway
- microServiceSLN.Mobile.Gateway

**Core** :

- microService.Database
- microService.Infra

**Visual Code create webapi commands**

- dotnet new sln --name microServiceSLN
- dotnet new webapi --name Person.api --framework netcoreapp2.1
- dotnet new webapi --name Message.api --framework netcoreapp2.1
- dotnet new webapi --name microServiceSLN.Desktop.Gateway --framework netcoreapp2.1
- dotnet new webapi --name microServiceSLN.Mobile.Gateway --framework netcoreapp2.1
- dotnet new classlib --name microService.Infra --framework netcoreapp2.1
- dotnet new classlib --name microService.Database --framework netcoreapp2.1
- code .

**Github commands**

- git init
- git add \*
- git commit –m &quot;initial commit&quot;
- git remote add origin [https://github.com/rohitnagvenkar/api-gateway-microservice.git](https://github.com/rohitnagvenkar/api-gateway-microservice.git)
- git push –u origin master