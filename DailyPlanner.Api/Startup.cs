﻿using Asp.Versioning;
using Microsoft.OpenApi.Models;

namespace DailyPlanner.Api
{
    public static class Startup
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddApiVersioning()
                .AddApiExplorer(options =>
                {
                    options.DefaultApiVersion = new ApiVersion(1, 0);
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl = true;
                    options.AssumeDefaultVersionWhenUnspecified = true;
                });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = "v1",
                    Title = "DailePlanner",
                    Description = "This is version 1.0",
                    TermsOfService = new Uri("https://vk.com/id158342275"),
                    Contact = new OpenApiContact()
                    {
                        Name = "Test contact",
                        Url = new Uri("https://vk.com/id158342275")
                    }
                });

                options.SwaggerDoc("v2", new OpenApiInfo()
                {
                    Version = "v2",
                    Title = "DailePlanner",
                    Description = "This is version 2.0",
                    TermsOfService = new Uri("https://vk.com/id158342275"),
                    Contact = new OpenApiContact()
                    {
                        Name = "Test contact",
                        Url = new Uri("https://vk.com/id158342275")
                    }
                });

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    In = ParameterLocation.Header,
                    Description = "Требуется ввести токен",
                    Name = "Авторизация",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        Array.Empty<string>()
                    }
                });
            });
        }
    }
}
