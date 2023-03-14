using egolfWebApi.Data;
using egolfWebApi.Extensions;
using egolfWebApi.Models.Member;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
// allow all origins
 
// Add services to the container.
    
builder.Services.AddControllers(); 
// builder.Services.AddDbContext<MemberContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("MemberList"));
builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("_myAllowSpecificOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();