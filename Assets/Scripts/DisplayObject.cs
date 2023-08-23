using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayObject : MonoBehaviour
{
    private Mesh mesh;
    public Material mat; //need to set material otherwise the mesh will ignore the colours being set here as default mesh doesnt support colours 


    // Start is called before the first frame update
    void Start()
    {
        //add a meshfilter and meshrenderer to the empty GameObject
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
     
        //set mat to the material we have selected 
        GetComponent<MeshRenderer>().material = mat;

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
        mesh.vertices = new Vector3[] {
            new Vector3(-7, 18, 0), 
            new Vector3(-7, 5, 0),
            new Vector3(16, 5, 0),
            new Vector3(16, 18, 0),
            new Vector3(-11, -4, 0),
            new Vector3(-11, 0, 0),
            new Vector3(-8, 0, 0),
            new Vector3(-8, -6, 0),
            new Vector3(-4, -6, 0),
            new Vector3(-4, -9, 0),
            new Vector3(3, -9, 0),
            new Vector3(11, -6, 0),
            new Vector3(11, -9, 0),
            new Vector3(15, -9, 0),
            new Vector3(14, -4, 0),
            new Vector3(17, -3, 0),
            new Vector3(16, 0 , 0),
            new Vector3(17, 0, 0),
            new Vector3(20, 0, 0),
            new Vector3(20, -4, 0),
            new Vector3(5, -6, 0),
            new Vector3(3, -6, 0),
            new Vector3(5, 5, 0),            
        };

        //specify triangle mesh
        mesh.triangles = new int[]{
            1,0,2,
            0,3,2,
            4,5,6,
            6,8,7,
            7,8,9,
            8,10,9,
            8,11,10,
            10,11,12,
            11,13,12,
            11,15,13,
            14,16,15,
            16,17,15,
            17,18,19,
            21,22,20
        };

        mesh.colors = new Color[]
        {
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.4f, 0.3f, 0.7f),
            new Color(0.4f, 0.3f, 0.7f),
            new Color(0.4f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
            new Color(0.8f, 0.3f, 0.7f),
        };

    }
}
