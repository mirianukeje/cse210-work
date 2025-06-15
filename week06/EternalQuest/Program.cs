// Exceeded Requirements: Added MilestoneGoal class.
// This goal type awards points at every milestone interval (for example, every 5 completions),
// helping users track progress toward large goals in a motivating way.


class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        gm.MainMenu();
    }
}
