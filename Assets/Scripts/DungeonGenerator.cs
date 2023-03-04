using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator
{
    private List<RoomNode> allSpaceNodes = new List<RoomNode>();
    private int dungeonWidth;
    private int dungeonLength;

    public DungeonGenerator(int dungeonWidth, int dungeonLength){
        this.dungeonWidth = dungeonWidth;
        this.dungeonLength = dungeonLength;
    }

    public List<Node> CalculateRooms(int iterations_max, int roomWidth_min, int roomLength_min)
    {
        BinarySpacePartitioner bsp = new BinarySpacePartitioner(dungeonWidth, dungeonLength);
        allSpaceNodes = bsp.PrepareNodesCollection(iterations_max, roomWidth_min,roomLength_min);
        List<Node> roomSpaces = StructureHelper.TraverseGraphToExtractLowestLeaves(bsp.RootNode);
        
        RoomGenerator roomGenerator = new RoomGenerator(iterations_max, roomLength_min, roomWidth_min);
        List<RoomNode> roomList = roomGenerator.GenerateRoomsInGivenSpace(roomSpaces);

        return new List<Node>(roomList);
    }
}
