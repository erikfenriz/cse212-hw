/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    // Dictionary to store the maze layout
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    // Current x and y coordinates
    private int _currX = 1;
    private int _currY = 1;

    // initialize the maze with a given map
    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft()
    {
        // safely attempt to get the directions 
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[0])
        {
            // if left movement is allowed, decrease x coordinate
            _currX--;
        }
        else
        {
            // inform if movement not allowed
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight()
    {
        // safely attempt to get the directions 
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[1])
        {
            // if right movement is allowed, increase x coordinate
            _currX++;
        }
        else
        {
            // inform if movement not allowed
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp()
    {
        // safely attempt to get the directions 
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[2])
        {
            // if up movement is allowed, decrease y coordinate
            _currY--;
        }
        else
        {
            // inform if movement not allowed
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown()
    {
        // safely attempt to get the directions 
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[3])
        {
            // if down movement is allowed, increase y coordinate
            _currY++;
        }
        else
        {
            // inform if movement not allowed
            Console.WriteLine("Can't go that way!");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}