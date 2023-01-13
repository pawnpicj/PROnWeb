using System;
using System.Text;
using BarCodeAPIService.Connection;
using BarCodeAPIService.Service;
using BarCodeAPIService.Service.MasterData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;

namespace BarCodeAPIService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

            #region AddScope

            services.AddScoped<ITokenService, TokenService>();
            //services.AddScoped<IGoodsReceiptPOService, GoodsReceiptPOService>();
            //services.AddScoped<IGoodReturnService, GoodReturnService>();
            //services.AddScoped<IStockDataService, StockDataService>();
            ////services.AddScoped<IBPMasterDataService, BPMasterDataService>();
            //services.AddScoped<IWarehouseService, WarehouseService>();
            //services.AddScoped<IItemMasterDataService, ItemMasterDataService>();
            //services.AddScoped<IBinCodeService, BinCodeService>();
            //services.AddScoped<ICostCenterService, CostCenterService>();
            //services.AddScoped<IBatchNumberService, BatchNumberService>();
            //services.AddScoped<ISerialNumberService, SerialNumberService>();
            //services.AddScoped<ISeriesIMService, SeriesIMService>();
            //services.AddScoped<ISeriesCVService, SeriesCVService>();
            //services.AddScoped<IGLAccountService, GLAccountService>();
            //services.AddScoped<IContactPersonService, ContactPersonService>();
            //services.AddScoped<IBPAddressService, BPAddressService>();
            //services.AddScoped<ISaleEmployeeService, SaleEmployeeService>();
            //services.AddScoped<IDocumentSeriesService, DocumentSeriesService>();
            //services.AddScoped<IPriceListService, PriceListService>();
            //services.AddScoped<IUserService, UserService>();

            //services.AddScoped<IInventoryTransferService, InventoryTransferService>();
            //services.AddScoped<IInventoryCountingService, InventoryCountingService>();
            //services.AddScoped<IInventoryTransferRequestService, InventoryTransferRequestService>();
            //services.AddScoped<IInventoryTransferIMService, InventoryTransferIMService>();
            //services.AddScoped<IStock_WhsBinService, Stock_WhsBinService>();
            //services.AddScoped<IGetBinLocationService, GetBinLocationService>();
            //services.AddScoped<IGetBinLocationListService, GetBinLocationListService>();
            //services.AddScoped<IDeliveryService, DeliveryService>();
            //services.AddScoped<IGenerateBinCodeServices, GenerateBinCodeService>();
            //services.AddScoped<IReturnService, ReturnService>();
            //services.AddScoped<ISalesOrderForIMService, SalesOrderForIMService>();

            //services.AddScoped<IStampService, StampService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            #endregion

            #region ConfigureJWTToken

            var tokenvalidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey =
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("Secret").Value)),
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };
            services.AddSingleton(tokenvalidationParameters);
            services.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.SaveToken = true;
                    x.TokenValidationParameters = tokenvalidationParameters;
                });

            #endregion

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BarCodeAPIService v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSerilogRequestLogging();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            ConnectionString.DbServerType = Configuration.GetSection("DbServerType").Value;
            ConnectionString.Server = Configuration.GetSection("Server").Value;
            ConnectionString.LicenseServer = Configuration.GetSection("LicenseServer").Value;
            ConnectionString.SLDServer = Configuration.GetSection("SLDServer").Value;
            ConnectionString.DbUserName = Configuration.GetSection("DbUserName").Value;
            ConnectionString.DbPassword = Configuration.GetSection("DbPassword").Value;
            ConnectionString.CompanyDB = Configuration.GetSection("CompanyDB").Value;
            ConnectionString.UserName = Configuration.GetSection("UserNameSAP").Value;
            ConnectionString.Password = Configuration.GetSection("Password").Value;
            ConnectionString.ConnHana = Configuration.GetSection("ConnectionStringHANA").Value;
            ConnectionString.BarcodeDb = Configuration.GetSection("BarCodeDB").Value;
        }
    }
}