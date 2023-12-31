using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Mesh mesh;
    private MeshCollider MC;
    
    public Material mat;
    public Vector3[] spawnPointLoco;
    public Vector3 worldOrigin = Vector3.zero;

    // public ShapeSpawner spawnPoints;
    
    public Vector3 movePoint = new Vector3();
    
    //position 
    private Vector3 position;

    private void Awake()
    {
        //add a meshfilter and meshrenderer to the empty GameObject
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();        
        
        mat = GetComponent<MeshRenderer>().material;
        mesh = GetComponent<MeshFilter>().mesh;

        MC = GetComponent<MeshCollider>();
        MC.sharedMesh = mesh;

        position = mesh.bounds.center;
        
        
        Display();

        
    }

    // Start is called before the first frame update
    void Start()
    {
       
        TranslatePoint(movePoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Display()
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
    
    
    public Matrix3x3 TranslatePoint(Vector3 curPosition)
    {
        // Get the vertices from the matrix
        Vector3[] vertices = mesh.vertices;
    
        // Get Scale
        // Matrix3x3 IM = IGB283Transform.Translate(-curPosition);
        
        Matrix3x3 M = IGB283Transform.Translate(mesh.bounds.center + curPosition);
    
        //Rotate each point in the mesh to its new position
        for(int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = M.MultiplyPoint(vertices[i]);
        } 
    
        //Set the vertices in the mesh to their new position
        mesh.vertices = vertices;
    
        // Recalculate the bounding volume
        mesh.RecalculateBounds();

        return M;
    }
    
}
