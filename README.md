# Web and Postgres
This is a mini project to show an example of running a .NET API project
connected to a postgres database all running within docker

## Docker Images
- Postgres (Database)
- PgAdmin (Database Admin Tool - Web based)

## .NET Projects
#### DatabaseUp
Leverages DbUp to do all CRUD operations on our postgres database from a c# codebase.
We also leverage [System.CommandLine](https://www.nuget.org/packages/System.CommandLine) to help parse commands