﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using System.Diagnostics.CodeAnalysis;

namespace ShareBooks.Application
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        public static void Main( string[] args )
        {
            CreateWebHostBuilder( args ).Build( ).Run( );
        }

        public static IWebHostBuilder CreateWebHostBuilder( string[] args ) =>
            WebHost.CreateDefaultBuilder( args )
                .UseSerilog( )
                .UseStartup<Startup>( );
    }
}
