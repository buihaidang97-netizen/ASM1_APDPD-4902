// Planned contract tests: run against BOTH repository implementations.
public abstract class StudentRepositoryContractTests
{
    protected abstract IStudentRepository CreateRepository();

    [Fact]
    public void MissingStudent_ReturnsNull() =>
        Assert.Null(CreateRepository().GetByStudentCode("MISSING"));

    [Fact]
    public void AddedStudent_CanBeRead()
    {
        var repo = CreateRepository();
        var user = CreateUser(1, "S001", "a@uni.edu");
        repo.Add(user);
        Assert.Equal(user.UserId, repo.GetByStudentCode("S001")?.UserId);
    }

    [Fact]
    public void DuplicateStudentCode_IsRejected()
    {
        var repo = CreateRepository();
        repo.Add(CreateUser(1, "S001", "a@uni.edu"));
        Assert.Throws<InvalidOperationException>(() =>
            repo.Add(CreateUser(2, "S001", "b@uni.edu")));
    }
}
// Run the inherited tests with an in-memory or CSV repository factory.
// CreateUser is the shared fixture builder used by both implementations.
