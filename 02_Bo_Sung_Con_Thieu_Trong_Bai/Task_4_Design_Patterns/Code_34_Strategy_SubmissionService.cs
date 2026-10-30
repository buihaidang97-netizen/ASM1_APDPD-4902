public class SubmissionService
{
    private readonly IEnumerable<IAssignmentGrader> _graders;
 
    public SubmissionService(IEnumerable<IAssignmentGrader> graders)
    {
        _graders = graders;
    }
 
    public float Grade(Submission submission, Assignment assignment)
    {
        IAssignmentGrader grader = _graders.FirstOrDefault(g => g.CanGrade(assignment.Type))
            ?? throw new InvalidOperationException($"No grader for {assignment.Type}.");
 
        float score = grader.Grade(submission, assignment);
        submission.Grade(score, assignment.MaxScore);
        return score;
    }
}
