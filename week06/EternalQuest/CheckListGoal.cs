public class CheckListGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _amountCompleted;

    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Overloaded constructor for loading
    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override string GetStatus() => _amountCompleted >= _target ? "[X]" : "[ ]";

    public override string GetDetailsString()
        => $"{GetStatus()} {_name} ({_description}) -- Completed: {_amountCompleted}/{_target}";

    public override string GetSaveString()
        => $"CheckListGoal:{_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}
