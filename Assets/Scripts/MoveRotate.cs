using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotate : IGB283Transform
{
    //Angle by which the triangle will rotate each frame
    public float angle = 10f;

    //changes in x and y axis
    public float dx;
    public float dy;

    //scale factors in x and y direction
    public float sx;
    public float sy;
    public Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the vertices from the matrix
        Vector3[] vertices = mesh.vertices;

        // Get rotation   
        Matrix3x3 R = Rotate(angle * Time.deltaTime);
        Matrix3x3 T = Translate(dx * Time.deltaTime, dy * Time.deltaTime);
        Matrix3x3 S = Scale(sx, sy);
        Matrix3x3 M = T * R * S;

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
