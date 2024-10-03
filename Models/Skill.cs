public record Skill(
    string Code,
    string Name,
    string Description,
    int Rating,
    DateTime Started,
    DateTime? Ended
)
{
    public int Years => ((Ended ?? DateTime.Now) - Started).Days / 365;
    public bool Current => Ended == null;
};