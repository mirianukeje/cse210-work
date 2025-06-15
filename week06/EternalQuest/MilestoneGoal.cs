public class MilestoneGoal : Goal
{
    private int _target;
    private int _progress;
    private int _milestoneSize;

    public MilestoneGoal(string name, string description, int points, int target, int milestoneSize)
        : base(name, description, points)
    {
        _target = target;
        _progress = 0;
        _milestoneSize = milestoneSize;
    }

    // Overloaded constructor for loading from file
    public MilestoneGoal(string name, string description, int points, int target, int milestoneSize, int progress)
        : base(name, description, points)
    {
        _target = target;
        _milestoneSize = milestoneSize;
        _progress = progress;
    }

    public override int RecordEvent()
    {
        // If goal is already completed, return 0 (no points)
        if (_progress >= _target)
        {
            return 0;
        }

        _progress++;

        // Award points at each milestone or at completion
        if (_progress % _milestoneSize == 0 || _progress == _target)
        {
            return _points; // milestone or completion achieved
        }

        // Progress made, but not a milestone
        return 0;
    }

    public override string GetStatus()
    {
        return _progress >= _target ? "[X]" : "[ ]";
    }

    public override string GetDetailsString()
    {
        return $"{GetStatus()} {_name} ({_description}) -- Progress: {_progress}/{_target} (milestone: every {_milestoneSize})";
    }

    public override string GetSaveString()
    {
        return $"MilestoneGoal:{_name}|{_description}|{_points}|{_target}|{_milestoneSize}|{_progress}";
    }
}
