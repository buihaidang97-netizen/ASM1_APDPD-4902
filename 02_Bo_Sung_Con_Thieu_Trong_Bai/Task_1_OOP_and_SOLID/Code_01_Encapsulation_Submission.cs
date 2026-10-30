public class Submission
{
    private float? _score;                 // hidden state
    public DateTime? GradedAt { get; private set; }
 
    public float? Score => _score;         // read-only from outside
 
    public void Grade(float score, float maxScore)
    {
        if (score < 0 || score > maxScore)
            throw new ArgumentException("Score must be between 0 and max score.");
        _score = score;
        GradedAt = DateTime.Now;
    }
}
