using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class ShapeSpawner : MonoBehaviour
{
    //gameobject shape
    /*
     * list of spawnpoints
     *
     * foreach spawnpoint in spawnpoints LOOP
     * Instantiate(shape, spawnpoints[spawnpoint].
     */

    private IGB283Transform transformScript;
    
    public GameObject shape;
    private DisplayObject DO;
    private Points _points;
    private double distanceToTravel;
    public spawnPoints SPointInfo;
    
    //spawn variable for origin
    public Vector3 worldOrigin = Vector3.zero;

    public List<spawnPoints> spawningPoints = new List<spawnPoints>();

    // Start is called before the first frame update
    void Start()
    {
        //getting the needed scripts to calcualte 
        transformScript = GetComponent<IGB283Transform>();
        DO = shape.GetComponent<DisplayObject>();
        // SPointInfo = GetComponent<spawnPoints>();
        
        
       SpawnObjects(spawningPoints);
        
        // Debug.Log( transformScript.getVectorFromPoints(spawningPoints[0].startPosition, spawningPoints[0].endPosition));
        // Debug.Log(distanceToTravel);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
        spawn in the point at origin
        after spawning in translate to desired point (thus setting our arbutary origin for the mesh)
         
      
     */

    public void SpawnObjects(List<spawnPoints> spawningPoints)
    {
        //spawns in points at desired positions  
        foreach (spawnPoints SP in spawningPoints)
        {
            _points = SP.StartPoint.GetComponent<Points>();

            //calculating magnitude for each spawn points  
            distanceToTravel = transformScript.getMagnitude(
                transformScript.getVectorFromPoints(SP.startPosition, SP.endPosition));


            DO.end = (float)distanceToTravel; // each clone now has its own magnitude to follow 

            //spawning all necessary objects at the desired position
            Instantiate(SP.StartPoint, SP.startPosition, Quaternion.identity); //Display the object

            //Translate it to the point that we want it, using
            // _points.TranslatePoint(SP.startPosition);

            Instantiate(SP.StartPoint, SP.endPosition, Quaternion.identity);
            // _points.TranslatePoint(SP.endPosition);

            // Instantiate(shape, SP.startPosition, Quaternion.identity);

            // Debug.Log();
        }
        
    }
    
    //translate the point to desired location 
    public Matrix3x3 ToPoint(Vector3 desiredPoint)
    {
        return null;
    }



}

//container for list of spawnpoints 
[Serializable]
public class spawnPoints
{
    //gameobject to represent spawnpoint
    public GameObject StartPoint;
    //spawn point position
    public Vector3 startPosition;
    
    // //gameobject to represent spawnpoint
    // public GameObject endPoint;
    //spawn point position
    public Vector3 endPosition;
}
