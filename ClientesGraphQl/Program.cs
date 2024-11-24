using ClientesGraphQl.Repository;
using ClientesGraphQl;

using HotChocolate.AspNetCore;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o ClienteRepository como um serviço
builder.Services.AddSingleton<ClienteRepository>();

// Configura o GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Mapeia o endpoint do GraphQL
app.MapGraphQL("/graphql");

app.Run();

