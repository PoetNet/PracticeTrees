using Database.PracticeTrees;
using Database.PracticeTrees.Chapters;
using Domain.Chapters;
using DotNetEnv;

Env.TraversePath().Load(".env");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IChapterQuery, ChapterQuery>();

builder.Services.AddDbContext<DocumentationDbContext>();

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
