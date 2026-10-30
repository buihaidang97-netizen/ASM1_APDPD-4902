public interface IAssignmentGrader
{
    bool CanGrade(AssignmentType type);
    float Grade(Submission submission, Assignment assignment);
}
 
public class QuizGrader : IAssignmentGrader
{
    public bool CanGrade(AssignmentType type) => type == AssignmentType.Quiz;
 
    public float Grade(Submission submission, Assignment assignment)
    {
        if (assignment.Questions.Count == 0)
            throw new InvalidOperationException("Quiz requires at least one question.");
        int correct = submission.Details.Count(detail => detail.IsCorrect());
        return assignment.MaxScore * correct / assignment.Questions.Count;
    }
}
 
public class EssayGrader : IAssignmentGrader
{
    public bool CanGrade(AssignmentType type) => type == AssignmentType.Essay;
 
    public float Grade(Submission submission, Assignment assignment) =>
        Math.Min(submission.TeacherScore, assignment.MaxScore);
}
