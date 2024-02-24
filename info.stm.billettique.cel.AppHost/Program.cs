using Microsoft.Extensions.Hosting;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<info_stm_billettique_cel_ApiService>("apiservice");

builder.AddProject<info_stm_billettique_cel_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
