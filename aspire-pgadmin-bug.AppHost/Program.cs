var builder = DistributedApplication.CreateBuilder(args);

var pg = builder.AddPostgres("pg")
    .WithPgAdmin()
    .AddDatabase("db");

builder.Build().Run();
