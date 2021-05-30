using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid 
{
    //Grid size
    public int width;
    public int hight;
    public float cellSize;
    public int[,] gridArray;

    public Grid(int width,int hight,float cellSize)
    {
        this.width = width;
        this.hight = hight;
        this.cellSize = cellSize;

        gridArray = new int[width, hight];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                //F cost
                CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) / 2, 40, Color.white, TextAnchor.MiddleCenter, TextAlignment.Center, 5000);
                //G cost
                CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(0.1f, cellSize), 20, Color.red, TextAnchor.UpperLeft, TextAlignment.Left, 5000);
                //H cost
                CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(cellSize, 0.1f), 20, Color.blue, TextAnchor.LowerRight, TextAlignment.Right, 5000);
            }
        }
    }

    public void DrawGridLine()
    {
        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                Debug.DrawRay(new Vector3(x, y, 0), Vector2.right * cellSize, Color.white);
                Debug.DrawRay(new Vector3(x, y, 0), Vector2.up * cellSize, Color.white);
            }
        }

        Debug.DrawRay(new Vector3(0, gridArray.GetLength(1), 0) * cellSize, new Vector3(gridArray.GetLength(0), 0, 0) * cellSize, Color.white);
        Debug.DrawRay(new Vector3(gridArray.GetLength(0), 0, 0) * cellSize, new Vector3(0, gridArray.GetLength(1), 0) * cellSize, Color.white);
    }

    private Vector3 GetWorldPosition(int x,int y)
    {
        return new Vector3(x, y) * cellSize;
    }

    public static TextMesh CreateWorldText(string text,Transform parent = null,Vector3 localPosition = default(Vector3),int fontSize = 20,Color? color = null,TextAnchor textAnchor = TextAnchor.UpperLeft,TextAlignment textAlignment = TextAlignment.Left,int sortingOrder = 5000)
    {
        if (color == null) color = Color.white;
        return CreateWorldText(parent, text, localPosition, fontSize, (Color)color, textAnchor, textAlignment, sortingOrder);
    }

    public static TextMesh CreateWorldText(Transform parent,string text,Vector3 localPosition,int fontSize,Color color,TextAnchor textAnchor,TextAlignment textAlignment,int sortingOrder)
    {
        GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
        Transform transform = gameObject.transform;
        transform.localScale = new Vector3(0.1f, 0.1f, 1);
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;
        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        textMesh.anchor = textAnchor;
        textMesh.alignment = textAlignment;
        textMesh.text = text;
        textMesh.fontSize = fontSize;
        textMesh.color = color;
        textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
        return textMesh;
    }
    
    


}
