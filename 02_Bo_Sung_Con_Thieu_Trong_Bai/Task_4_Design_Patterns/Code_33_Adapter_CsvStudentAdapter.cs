using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class CsvStudentAdapter : IStudentRepository
{
    private const string FileName = "users.csv";
    private readonly CsvFileStore _store;

    public CsvStudentAdapter(CsvFileStore store) => _store = store;

    private IEnumerable<User> ReadUsers() =>
        _store.ReadRows(FileName).Select(FromCsv);

    public User? GetByStudentCode(string studentCode) =>
        ReadUsers().FirstOrDefault(user =>
            string.Equals(user.StudentCode, studentCode,
                StringComparison.OrdinalIgnoreCase));

    public void Add(User user)
    {
        var users = ReadUsers();
        bool duplicateKey = users.Any(existing =>
            existing.UserId == user.UserId ||
            string.Equals(existing.Email, user.Email, StringComparison.OrdinalIgnoreCase) ||
            string.Equals(existing.StudentCode, user.StudentCode,
                StringComparison.OrdinalIgnoreCase));

        if (duplicateKey)
            throw new InvalidOperationException("User ID, email or student code already exists.");

        _store.AppendRow(FileName, ToCsv(user));
    }

    public void Update(User user)
    {
        var users = ReadUsers();
        if (!users.Any(existing => existing.UserId == user.UserId))
            throw new KeyNotFoundException("User not found.");

        bool duplicateKey = users.Any(existing => existing.UserId != user.UserId &&
            (string.Equals(existing.Email, user.Email, StringComparison.OrdinalIgnoreCase) ||
             string.Equals(existing.StudentCode, user.StudentCode,
                 StringComparison.OrdinalIgnoreCase)));

        if (duplicateKey)
            throw new InvalidOperationException("Email or student code already exists.");

        _store.ReplaceRow(FileName,
            row => row.Length > 0 && row[0] == user.UserId.ToString(), ToCsv(user));
    }

    private static string[] ToCsv(User user) => new[] {
        user.UserId.ToString(CultureInfo.InvariantCulture),
        user.MajorId?.ToString(CultureInfo.InvariantCulture) ?? "",
        user.Role.ToString(), user.Email, user.HashPassword, user.FullName,
        user.DateOfBirth.ToString("O", CultureInfo.InvariantCulture),
        ((byte)user.Gender).ToString(CultureInfo.InvariantCulture),
        user.Address ?? "", user.Phone ?? "", user.Avatar ?? "",
        user.RememberToken ?? "",
        user.CreatedAt.ToString("O", CultureInfo.InvariantCulture),
        user.UpdatedAt.ToString("O", CultureInfo.InvariantCulture),
        user.StudentCode
    };

    private static User FromCsv(string[] row)
    {
        if (row.Length != 15)
            throw new FormatException("Invalid users.csv row: expected 15 columns.");

        return new User {
            UserId = long.Parse(row[0], CultureInfo.InvariantCulture),
            MajorId = string.IsNullOrWhiteSpace(row[1])
                ? null : long.Parse(row[1], CultureInfo.InvariantCulture),
            Role = Enum.Parse<UserRole>(row[2]),
            Email = row[3], HashPassword = row[4], FullName = row[5],
            DateOfBirth = DateTime.Parse(row[6], CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Gender = (Gender)byte.Parse(row[7], CultureInfo.InvariantCulture),
            Address = row[8], Phone = row[9], Avatar = row[10],
            RememberToken = row[11],
            CreatedAt = DateTime.Parse(row[12], CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedAt = DateTime.Parse(row[13], CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            StudentCode = row[14]
        };
    }
}
