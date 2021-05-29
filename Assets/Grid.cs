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

        for(int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                CreateWorldText(gridArray[x, y].ToString(),null,GetWorldPosition(x,y),20,Color.white,TextAnchor.MiddleCenter,TextAlignment.Center,5000);
            }
        }
    }

    private Vector3 GetWorldPosition(int x,int y)
    {
        return new Vector3(x, y) * cellSize;
    }

    public static TextMesh CreateWorldText(string text,Transform parent = null,Vector3 localPosition = default(Vector3),int fontSize = 40,Color? color = null,TextAnchor textAnchor = TextAnchor.UpperLeft,TextAlignment textAlignment = TextAlignment.Left,int sortingOrder = 5000)
    {
        if (color == null) color = Color.white;
        return CreateWorldText(parent, text, localPosition, fontSize, (Color)color, textAnchor, textAlignment, sortingOrder);
    }
    public static TextMesh CreateWorldText(Transform parent,string text,Vector3 localPosition,int fontSize,Color color,TextAnchor textAnchor,TextAlignment textAlignment,int sortingOrder)
    {
        GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
        Transform transform = gameObject.transform;
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
