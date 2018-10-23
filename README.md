
# aspnetcore-generator-api
Sample ASP.NET Core API that generates random data, has swagger UI too

# create unit test project
required: .Net SDK
dotnet new xunit -o tests
add reference project. go to tests directories
dotnet add reference ..\api\api.csproj
dotnet restore
dotnet test

docker build -t testting .
docker run -rm testing ls -alR
docker run -rm -it testing -p 8080:8080