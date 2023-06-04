using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CardsPlaces : MonoBehaviour
{
    [SerializeField]
    private GameObject mouseOverCellIndicator;

    [SerializeField]
    private InputPosition inputPosition;

    [SerializeField]
    private Grid grid;

    private Vector3 cellCenter;

    // Start is called before the first frame update
    void Start()
    {
        var position = grid.GetLayoutCellCenter();
        cellCenter = new Vector3(position.x, 0, position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = inputPosition.GetSelectedGridCell();
        Vector3Int cellPosition = grid.WorldToCell(mousePosition);
        mouseOverCellIndicator.transform.position = grid.CellToWorld(cellPosition) + cellCenter;

    }
}
