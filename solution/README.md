dotnet new --install NUnit3.DotNetNew.Template

dotnet new classlib --name DevFX
dotnet new nunit --name DevFX.Tests
dotnet add DevFX.Tests/DevFX.Tests.csproj reference DevFX/DevFX.csproj