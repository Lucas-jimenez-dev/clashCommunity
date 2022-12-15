

using clashCommunity_api;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/*Récupère le secret et le stocke dans un objet de type (classe) SecretSettings.
 * 
 * Dans le secret.json : 

    {
        "db:ConnectionString": "Server=(localdb)\\mssqllocaldb;Database=Movie-1;Trusted_Connection=True;MultipleActiveResultSets=true",
        "db:ServiceApiKey": "toto"
    }
*/

var SecretConfig = builder.Configuration.GetSection("db").Get<SecretSettings>();
var connectionString = SecretConfig.ConnectionString;
connectionString = "Server=localhost;Database=clashcommunitydb;User=root; Password=root; Port=3309";
//Configure DataDBContext avec le secret récupéré dans l'objet
builder.Services.AddDbContext<DataDbContext>();


builder.Services.AddScoped<UserAppRepository>();
builder.Services.AddScoped<CandidatureRepository>();
builder.Services.AddScoped<ClanRepository>();
builder.Services.AddScoped<RoleAppRepository>();

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
