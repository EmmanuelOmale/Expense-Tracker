using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ApplicationCore.Extensions
{
    public static class AuthenticationExtensions
    {
        public static void AddJWTAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateLifetime = true,
                        ValidateAudience = configuration.GetSection("Jwt:Audience").Value != null,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration.GetSection("Jwt:Issuer").Value ?? null,
                        ValidAudience = configuration.GetSection("Jwt:Audience").Value ?? null,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetValue<string>("Jwt:Token") ?? string.Empty))

                    };
                });
        }
    }
}
