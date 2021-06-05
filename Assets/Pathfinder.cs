using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    public Grid grid;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public Vector3 startNode;
    public Vector3 endNode;
    public List<pathNode> feasibleNodes;
    public List<pathNode> selectedNodes;
    public List<pathNode> shortestPathNodes;

    public class pathNode{
        public Vector2 nodePosition;
        public bool isWalkable;
        public int F_cost;
        public int G_cost;
        public int H_cost;
    }

    void Start()
    {
        grid = FindObjectOfType<Grid>();
    }

    void Update()
    {
        
    }

    public void findShortestPath(Vector3 startPosition,Vector3 endPosition)
    {
        this.startPosition = startPosition;
        this.endPosition = endPosition;

        startNode = grid.WorldToCell(startPosition);
        endNode = grid.WorldToCell(endPosition);


    }
}
