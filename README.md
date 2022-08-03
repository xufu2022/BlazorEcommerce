# BlazorEcommerce

dotnet new --list
dotnet new sln --name BlazorEcommerce
dotnet new blazorserver -o 'Server\BlazorEcommerce.Server'
dotnet new blazorwasm -o 'Client\BlazorEcommerce.Client'
dotnet new classlib -o 'Shared\BlazorEcommerce.Shared'

dotnet sln add 'Server\BlazorEcommerce.Server'
dotnet sln add 'Client\BlazorEcommerce.Client'
dotnet sln add 'Shared\BlazorEcommerce.Shared'

dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' reference Client\BlazorEcommerce.Client\BlazorEcommerce.Client.csproj
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' reference Shared\BlazorEcommerce.Shared\BlazorEcommerce.Shared.csproj
dotnet add 'Client\BlazorEcommerce.Client\BlazorEcommerce.Client.csproj' reference Shared\BlazorEcommerce.Shared\BlazorEcommerce.Shared.csproj

dotnet add 'Client\BlazorEcommerce.Client\BlazorEcommerce.Client.csproj' package Blazored.LocalStorage
dotnet add 'Client\BlazorEcommerce.Client\BlazorEcommerce.Client.csproj' package Microsoft.AspNetCore.Components.Authorization
dotnet add 'Client\BlazorEcommerce.Client\BlazorEcommerce.Client.csproj' package Microsoft.AspNetCore.WebUtilities
dotnet add 'Client\BlazorEcommerce.Client\BlazorEcommerce.Client.csproj' package MudBlazor

dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Microsoft.AspNetCore.Components.WebAssembly.Server
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Microsoft.EntityFrameworkCore
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Microsoft.EntityFrameworkCore.Design
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Microsoft.EntityFrameworkCore.SqlServer
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Stripe.net
dotnet add 'Server\BlazorEcommerce.Server\BlazorEcommerce.Server.csproj' package Swashbuckle.AspNetCore



dotnet tool install --global dotnet-ef
dotnet ef

dotnet ef migrations add CreateInitial

