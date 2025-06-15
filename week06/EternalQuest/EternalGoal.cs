public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override int RecordEvent() => _points; // Always awards points, never complete

    public override string GetStatus() => "[∞]";
}
