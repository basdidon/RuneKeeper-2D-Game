using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public Grid grid;
    void Start()
    {
        grid = new Grid(3, 5,1f);
    }

    private void FixedUpdate()
    {
        grid.DrawGridLine();
    }
}
