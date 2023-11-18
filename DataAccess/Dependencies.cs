using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Models;
// ======================== for use mysql pomelo and another else
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Relational;

namespace DataAccess;

public static class Dependencies
{
    public static void ConfigurationDB(IConfiguration configuration, IServiceCollection services){
        services.AddDbContext<GoBlogContext>(optionsBuilder =>
            {
                optionsBuilder.UseMySql(configuration.GetConnectionString("GoBlogConnection"),
                Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));
             }
        );
    }
}

// ConnectionString => "server=localhost;user=root;database=go_blog"
// => optionsBuilder.UseMySql("server=localhost;user=root;database=go_blog", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));