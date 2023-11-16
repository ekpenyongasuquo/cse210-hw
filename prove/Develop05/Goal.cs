public abstract class Goal
{
    protected bool _isCompleted;
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _type;

    public Goal (string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public abstract void SetIsCompleted();
    public abstract void DisplayGoal(int option); //user.RecordEvent will use the option to show a list of the goals without the checkbox and description
    public abstract string GetStringRep();


    //GETTERS
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public int GetPoints()
    {
        return _points;
    }

}