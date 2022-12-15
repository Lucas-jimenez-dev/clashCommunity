

using clashCommunity_api;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/*R�cup�re le secret et le stocke dans un objet de type (classe) SecretSettings.
 * 
 * Dans le secret.json : 

    {
        "db:ConnectionString": "Server=(localdb)\\mssqllocaldb;Database=Movie-1;Trusted_Connection=True;MultipleActiveResultSets=true",
        "db:ServiceApiKey": "toto"
    }
*/

var SecretConfig = builder.Configuration.GetSection("db").Get<SecretSettings>();
var connectionString = SecretConfig.ConnectionString;

//Configure DataDBContext avec le secret r�cup�r� dans l'objet
builder.Services.AddDbContext<DataDbContext>(option =>
{
    option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});



builder.Services.AddScoped<UserRepository>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
