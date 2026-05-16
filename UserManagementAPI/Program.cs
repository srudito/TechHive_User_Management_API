using UserManagementAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ 1. Error handling FIRST
app.UseMiddleware<ErrorHandlingMiddleware>();

// ✅ 2. Authentication
app.UseMiddleware<AuthenticationMiddleware>();

// ✅ 3. Logging LAST
app.UseMiddleware<LoggingMiddleware>();

// Swagger (keep after middleware so it's reachable)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Optional
// app.UseHttpsRedirection();

// app.UseAuthorization();

app.MapControllers();

app.Run();