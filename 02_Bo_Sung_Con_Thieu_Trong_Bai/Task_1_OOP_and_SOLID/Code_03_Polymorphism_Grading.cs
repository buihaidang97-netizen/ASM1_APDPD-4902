public abstract class AssignmentGrader
{
    public abstract float Grade(Submission submission, Assignment assignment);
}
 
public class QuizGrader : AssignmentGrader
{
    public override float Grade(Submission submission, Assignment assignment)
    {
        if (assignment.Questions.Count == 0)
            throw new InvalidOperationException("Quiz requires at least one question.");
        int correct = submission.Details.Count(d => d.IsCorrect());
        return assignment.MaxScore * correct / assignment.Questions.Count;
    }
}
 
public class EssayGrader : AssignmentGrader
{
    public override float Grade(Submission submission, Assignment assignment)
    {
        return Math.Min(submission.TeacherScore, assignment.MaxScore);
    }
}
