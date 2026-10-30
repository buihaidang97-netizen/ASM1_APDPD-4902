var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CsvFileStore>();
builder.Services.AddScoped<CsvStudentAdapter>();
builder.Services.AddScoped<IStudentRepository>(sp => sp.GetRequiredService<CsvStudentAdapter>());
builder.Services.AddScoped<IStudentReader>(sp => sp.GetRequiredService<CsvStudentAdapter>());
builder.Services.AddScoped<IStudentWriter>(sp => sp.GetRequiredService<CsvStudentAdapter>());
builder.Services.AddScoped<IClassRoomRepository, CsvClassRoomRepository>();
builder.Services.AddScoped<IAssignmentGrader, QuizGrader>();
builder.Services.AddScoped<IAssignmentGrader, EssayGrader>();
builder.Services.AddScoped<EnrollmentService>();
builder.Services.AddScoped<SubmissionService>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
    options.AddPolicy("TeacherOnly", policy => policy.RequireRole("Teacher"));
});

var app = builder.Build();
