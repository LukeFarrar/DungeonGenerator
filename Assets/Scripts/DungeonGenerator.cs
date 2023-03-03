using System;
using UnityEngine;

public class DungeonGenerator
{
    private RoomNode rootNode;
    private List<RoomNode> allSpaceNodes = new list<RoomNode>();
    private int dungeonWidth;
    private int dungeonLength;
    private int dungeonHeight;

    public DungeonGenerator(int dungeonWidth, int dungeonLength){
        this.dungeonWidth = dungeonWidth;
        this.dungeonLength = dungeonLength;
    }

    public DungeonGenerator(int dungeonWidth, int dungeonLength, int dungeonHeight)
    {
        this.dungeonWidth = dungeonWidth;
        this.dungeonLength = dungeonLength;
        this.dungeonHeight = dungeonHeight;
    }

    internal object CalculateRooms(int iterations_max, int roomWidth_min, int roomLength_min){

    }

    internal object CalculateRooms(int iterations_max, int roomWidth_min, int roomLength_min, int roomHeight_min){
        
    }
}
