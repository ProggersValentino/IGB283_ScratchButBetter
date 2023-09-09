using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public bool isMoving = false;
    public Vector3 offset;
    public Vector3 screenPoint;

    private Mesh mesh;
    public Material mat;
    public Vector3[] spawnPointLoco;

    // Start is called before the first frame update
    void Start()
    {
        //add a meshfilter and meshrenderer to the empty GameObject
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();        
        
        mat = GetComponent<MeshRenderer>().material;
        mesh = GetComponent<MeshFilter>().mesh;
        
        Display();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Display()
    {
        mesh.vertices = new Vector3[]
        {
            spawnPointLoco[0],
            spawnPointLoco[1],
            spawnPointLoco[2],
            spawnPointLoco[3],
        };

        mesh.triangles = new int[]
        {
            0, 1, 2,
            0, 2, 3
        };
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

    void OnMouseDown()
    {
        Debug.Log("mouse down");
        screenPoint = Camera.main.WorldToScreenPoint(mesh.bounds.center);
        offset = mesh.bounds.center;
        offset = mesh.bounds.center
        - Camera.main.ScreenToWorldPoint(
        new Vector3(offset.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Debug.Log("drag");
        Vector3 curScreenPoint = new Vector3(mesh.bounds.center.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        //TranslatePoint(curPosition);
        // audio. Play();
    }

    void TranslatePoint(Vector3 curPosition)
    {
        // Get the vertices from the matrix
        Vector3[] vertices = mesh.vertices;

        // Get Scale
        Matrix3x3 M = IGB283Transform.Translate(curPosition);

        //Rotate each point in the mesh to its new position
        for(int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = M.MultiplyPoint(vertices[i]);
        } 

        //Set the vertices in the mesh to their new position
        mesh.vertices = vertices;

        // Recalculate the bounding volume
        mesh.RecalculateBounds(); 
    }
}