using Example.Extension;
using Example.Storage.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Linq;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), o =>
	{
		o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
	}));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddWebServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Example", Version = "v1" });
	c.ResolveConflictingActions(apiDescription => apiDescription.First());

	foreach (FileInfo file in new DirectoryInfo(AppContext.BaseDirectory).GetFiles(
				 Assembly.GetExecutingAssembly().GetName().Name! + ".xml"))
		c.IncludeXmlComments(file.FullName);

	c.EnableAnnotations(enableAnnotationsForInheritance: true,
		enableAnnotationsForPolymorphism: true
	);
});

var app = builder.Build();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();

	app.UseSwagger();
	app.UseSwaggerUI(options =>
	{
		options.SwaggerEndpoint("/swagger/v1/swagger.json", "Example");
		options.EnableDeepLinking();
	});
}

app.UseStaticFiles(); ; ;

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
