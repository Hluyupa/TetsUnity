using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPosition : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    private Vector3 _lastPosition;

    [SerializeField]
    private LayerMask activeLayerMask;
    
    public Vector3 GetSelectedGridCell()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, activeLayerMask))
        {
            _lastPosition = hitInfo.point;
        }
        return _lastPosition;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
