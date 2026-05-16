<<<<<<< HEAD
using UserManagementAPI.Middleware;

=======
>>>>>>> origin/codespace-super-duper-adventure-54vv779q69gc4wj
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

<<<<<<< HEAD
// ✅ 1. Error handling FIRST
app.UseMiddleware<ErrorHandlingMiddleware>();

// ✅ 2. Authentication
app.UseMiddleware<AuthenticationMiddleware>();

// ✅ 3. Logging LAST
app.UseMiddleware<LoggingMiddleware>();

// Swagger (keep after middleware so it's reachable)
=======
// Configure middleware
>>>>>>> origin/codespace-super-duper-adventure-54vv779q69gc4wj
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

<<<<<<< HEAD
// Optional
// app.UseHttpsRedirection();

// app.UseAuthorization();
=======
//app.UseHttpsRedirection();
app.UseAuthorization();
>>>>>>> origin/codespace-super-duper-adventure-54vv779q69gc4wj

app.MapControllers();

app.Run();