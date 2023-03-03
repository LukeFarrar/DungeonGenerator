using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCreator : MonoBehaviour
{
    public int dungeonWidth, dungeonLength;
    public int roomWidth_min, roomLength_min;
    public int iterations_max;
    public int corridoorWidth;

    // Start is called before the first frame update
    void Start()
    {
        CreateDungeon();
    }

    private void CreateDungeon()
    {
        DungeonGenerator generator = new DungeonGenerator(dungeonWidth, dungeonLength);
        var listOfRooms = generator.CalculateRooms(iterations_max, roomWidth_min, roomLength_min);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
