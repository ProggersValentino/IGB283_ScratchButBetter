using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public bool isMoving = false;
    public Vector3 offset;
    public Vector3 screenPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position
        - Camera.main.ScreenToWorldPoint(
        new Vector3(transform.position.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(transform.position.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
