using System;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator
{
    private int iterations_max;
    private int roomLength_min;
    private int roomWidth_min;
    public RoomGenerator(int iterations_max, int roomLength_min, int roomWidth_min)
    {
        this.iterations_max = iterations_max;
        this.roomLength_min = roomLength_min;
        this.roomWidth_min = roomWidth_min;
    }

    public List<RoomNode> GenerateRoomsInGivenSpace(List<Node> roomSpaces)
    {
        List<RoomNode> listToReturn  = new List<RoomNode>();
        
        foreach(var space in roomSpaces)
        {
            Vector2Int newBottomLeftPoint = StructureHelper.GenerateBottomLeftCornerBetween(space.BottomLeftAreaCorner, space.TopRightAreaCorner, 0.1f, 1);
            Vector2Int newTopRightPoint = StructureHelper.GenerateTopRightCornerBetween(space.BottomLeftAreaCorner, space.TopRightAreaCorner, 0.9f, 1);
            space.BottomLeftAreaCorner = newBottomLeftPoint;
            space.TopRightAreaCorner = newTopRightPoint;
            space.BottomRightAreaCorner = new Vector2Int(newTopRightPoint.x, newBottomLeftPoint.y);
            space.TopRightAreaCorner = new Vector2Int(newBottomLeftPoint.y, newTopRightPoint.y);
            listToReturn.Add((RoomNode)space);
        }

        return listToReturn;
    }
}