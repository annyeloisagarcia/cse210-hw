public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int timesCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent(ref int score)
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            score += _points;
            if (_timesCompleted == _target)
                score += _bonus;
        }
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus()
        => $"[{(IsComplete() ? "X" : " ")}] Completed {_timesCompleted}/{_target}";

    public override string GetStringRepresentation()
        => $"ChecklistGoal:{_name},{_description},{_points},{_timesCompleted},{_target},{_bonus}";
}
