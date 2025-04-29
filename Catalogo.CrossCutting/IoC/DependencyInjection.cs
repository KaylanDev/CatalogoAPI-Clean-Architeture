using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Infrastruture.Context;
using Microsoft.EntityFrameworkCore;
using Catalogo.Domain.Interfaces;
using Catalogo.Infrastruture.Repositories;
using Catalogo.Application.Mappings;
using Catalogo.Application.Interfaces;
using Catalogo.Application.Services;
namespace Catalogo.CrossCutting.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<ICategoriaService, CategoriaService>();
        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddAutoMapper(typeof(DomainToMappinProfile));
        return services;
    }
}
