FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the .csproj and restore as distinct layers
COPY source/tictactoe.Application/tictactoe.Application.csproj source/tictactoe.Application/tictactoe.Application.csproj
COPY source/tictactoe.Logic/tictactoe.Logic.csproj source/tictactoe.Logic/tictactoe.Logic.csproj
COPY tests/tictactoe.Application.Test/tictactoe.Application.Test.csproj tests/tictactoe.Application.Test/tictactoe.Application.Test.csproj
COPY tests/tictactoe.Logic.Test/tictactoe.Logic.Test.csproj tests/tictactoe.Logic.Test/tictactoe.Logic.Test.csproj
COPY *.sln ./
RUN dotnet restore

# Copy the remaining source code and build the application
COPY tests/ tests
COPY source/ source
RUN dotnet build
RUN dotnet test
RUN dotnet publish -c Release -o out

# ---FINAL STAGE---
FROM cgr.dev/chainguard/dotnet-runtime:latest AS final
WORKDIR /
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "tictactoe.Application.dll"]



