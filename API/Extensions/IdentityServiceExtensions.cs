using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
         public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
         {
             service.AddAuthentication(JwtBearerDefualts.AuthenticationScheme)
                .AddJwtBearer(option +>
                {
                    options.TokenValidationParameter = new TokenValidationParameter
                    {
                        ValidationIssuerSigningKey = true,
                        IssuerSingingKey = new SymmetricSecuritKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });  
                return services;
         }
    }
}