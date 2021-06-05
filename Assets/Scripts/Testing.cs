using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    //public Grid grid;
    void Start()
    {
        //grid = new Grid(3, 5,1f);

        Grid grid = transform.parent.GetComponent<Grid>();
        Vector3Int cellPosition = grid.WorldToCell(transform.position);
        Debug.Log(cellPosition.ToString());
        transform.position = grid.GetCellCenterWorld(cellPosition);
    }

    private void FixedUpdate()
    {
        //grid.DrawGridLine();
    }
}
