﻿using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;


namespace ShareBooks.Application.Middlewares
{
    [ExcludeFromCodeCoverage]
    public static class SwaggerMeddleware
    {
        public static void AddSwaggerMiddleware( this IServiceCollection services )
        {
            services.AddSwaggerGen( c =>
            {
                c.SwaggerDoc( "v1",
                    new Info
                    {
                        Title = "Share Books",
                        Version = "v1",
                        Description = "Share Books API"
                    } );

                var appPath =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var xmlDocPath =
                    Path.Combine( appPath, "ShareBooks.Application.xml" );

                c.IncludeXmlComments( xmlDocPath );
            } );
        }

        public static void UseSwaggerMiddleware( this IApplicationBuilder app )
        {
            app.UseSwagger( );
            app.UseSwaggerUI( c =>
            {
                c.SwaggerEndpoint( "/swagger/v1/swagger.json",
                    "ShareBooks.Application" );
                c.RoutePrefix = "docs";
            } );
        }
    }
}
