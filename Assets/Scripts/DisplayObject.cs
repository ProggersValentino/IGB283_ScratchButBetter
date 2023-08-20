using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayObject : MonoBehaviour
{
    private Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        Display();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Display()
    {
        //display object 
        
        //define object
        //mesh.vertices = new Vector3[] {};

        //specify triangle mesh
        /*mesh.triangles = new int[]{
            0,1,5,
            4,2,1,
            3,6,2,
            8,7,6,
            9,10,7,
            0,19,10,
            14,12,11,
            14,13,12,
            18,16,15,
            18,17,16,
            0,24,19,
            24,20,19,
            23,22,21,
        };*/
    }
}
