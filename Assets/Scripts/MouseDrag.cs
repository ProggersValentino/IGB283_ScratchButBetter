using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public bool isMoving = false;
    public Vector3 offset;
    public Vector3 screenPoint;

    private Points points;
    private Mesh mesh;
    
    // Start is called before the first frame update
    void Start()
    {
        points = GetComponent<Points>();
        mesh = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnMouseDown()
    // {
    //     screenPoint = Camera.main.WorldToScreenPoint(mesh.bounds.center);
    //     offset = mesh.bounds.center;
    //     offset = mesh.bounds.center
    //     - Camera.main.ScreenToWorldPoint(
    //     new Vector3(offset.x, Input.mousePosition.y, screenPoint.z));
        
    //     Debug.Log(offset);
    // }
    // void OnMouseDrag()
    // {
    //     Vector3 curScreenPoint = new Vector3(transform.position.x, Input.mousePosition.y, screenPoint.z);
    //     Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    //     transform.position = curPosition;
    // }
    
    //when mouse is press down then activate this method
    void OnMouseDown()
    {
        Debug.Log("mouse down");
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        // offset = mesh.bounds.center;
        offset = mesh.bounds.center
        - Camera.main.ScreenToWorldPoint(
        new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z)); // calcualtes the offset based on the meshes centre and the currentposition where the
        //mouse is 
        
    }
    void OnMouseDrag()
    {
        Debug.Log("drag");
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        // points.TranslatePoint(curPosition - curScreenPoint);
        // audio. Play();
    }

   
}