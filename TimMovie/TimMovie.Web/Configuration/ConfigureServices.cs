﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.Options;
using TimMovie.Core.Classes;
using TimMovie.Core.Entities;
using TimMovie.Core.Interfaces;
using TimMovie.Infrastructure.Database.Repositories;
using TimMovie.Infrastructure.Services;
using TimMovie.Infrastructure.StartupSetup;
using TimMovie.SharedKernel.Interfaces;

namespace TimMovie.Web.Configuration;

public static class ServicesConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext(configuration.GetConnectionString("DefaultConnection"));
        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Account/Login";
            options.AccessDeniedPath = "/Account/Denied";
        });
        services.AddAuthentication().AddVkontakte(configuration);
        services.AddAuthorization();
        services.AddControllersWithViews();
        services.AddAutoMapper(typeof(AppMappingProfile));
        services.AddScoped<Repository<Banner>>();
        services.AddScoped<Repository<Film>>();
        
       services.Configure<MailSetup>(configuration.GetSection("MailSetup"));
       services.AddScoped(x => x.GetService<IOptions<MailSetup>>()!.Value);
       services.AddScoped<IMailService,MailKitService>();
       services.AddScoped<IUserMessageService, UserMessageService>();
       return services;
    }
}