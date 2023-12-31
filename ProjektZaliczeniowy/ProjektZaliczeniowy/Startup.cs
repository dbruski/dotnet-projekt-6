using DataStoreInMemory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjektZaliczeniowy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC;
using UC.DataStoreInterfaces;
using UC.PatientsUseCases;
using UC.ServicesUseCases;
using UC.TransactionsUseCases;

namespace ProjektZaliczeniowy
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            // Dependencies injection for temporary in memory storing data
            services.AddScoped<ICategoryRepo, CategoryInMemoryRepo>();
            services.AddScoped<IServiceRepo, ServiceInMemoryRepo>();
            services.AddScoped<IPatientRepo, PatientInMemoryRepo>();
            services.AddScoped<ITransactionRepo, TransactionInMemoryRepo>();
            services.AddScoped<IDoctorRepo, DoctorInMemoryRepo>();

            // Dependencies injection for use cases and repos
            services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
            services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
            services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

            services.AddTransient<IViewServicesUseCase, ViewServicesUseCase>();
            services.AddTransient<IAddServiceUseCase, AddServiceUseCase>();
            services.AddTransient<IEditServiceUseCase, EditServiceUseCase>();
            services.AddTransient<IGetServiceByIdUseCase, GetServiceByIdUseCase>();
            services.AddTransient<IDeleteServiceUseCase, DeleteServiceUseCase>();

            services.AddTransient<IViewPatientsUseCase, ViewPatientsUseCase>();
            services.AddTransient<IAddPatientUseCase, AddPatientUseCase>();
            services.AddTransient<IEditPatientUseCase, EditPatientUseCase>();
            services.AddTransient<IGetPatientByIdUseCase, GetPatientByIdUseCase>();
            services.AddTransient<IDeletePatientUseCase, DeletePatientUseCase>();

            services.AddTransient<IViewTransactionsUseCase, ViewTransactionsUseCase>();
            services.AddTransient<IAddTransactionUseCase, AddTransactionUseCase>();
            services.AddTransient<IViewTransactionsBetweenUseCase, ViewTransactionsBetweenUseCase>();
            services.AddTransient<IViewTodaysTransactionsUseCase, ViewTodaysTransactionsUseCase>();
            services.AddTransient<IViewTransactionByDoctor, ViewTransactionByDoctor>();
            services.AddTransient<IViewTransactionByPatient, ViewTransactionByPatient>();

            services.AddTransient<IViewDoctorsUseCase, ViewDoctorsUseCase>();
            services.AddTransient<IAddDoctorUseCase, AddDoctorUseCase>();
            services.AddTransient<IGetDoctorByIdUseCase, GetDoctorByIdUseCase>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
