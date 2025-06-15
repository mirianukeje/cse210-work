public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name => _name;

    public abstract int RecordEvent();

    public virtual string GetStatus() => "[ ]";
    public virtual string GetDetailsString() => $"{GetStatus()} {_name} ({_description})";
    public virtual string GetSaveString() => $"{GetType().Name}:{_name}|{_description}|{_points}";

   public static Goal LoadFromString(string data)
{
    string[] parts = data.Split(':');
    string type = parts[0];
    string[] args = parts[1].Split('|');

    switch (type)
    {
        case "SimpleGoal":
            return new SimpleGoal(args[0], args[1], int.Parse(args[2]), bool.Parse(args[3]));
        case "EternalGoal":
            return new EternalGoal(args[0], args[1], int.Parse(args[2]));
        case "CheckListGoal":
            return new CheckListGoal(
                args[0], args[1], int.Parse(args[2]),
                int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5])
            );
        case "MilestoneGoal":
            return new MilestoneGoal(
                args[0], args[1], int.Parse(args[2]),
                int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5])
            );
        default: throw new Exception("Unknown goal type");
    }
}

}
