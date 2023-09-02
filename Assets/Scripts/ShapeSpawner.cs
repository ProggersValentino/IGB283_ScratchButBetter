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
    private double distanceToTravel;
    
    public List<spawnPoints> spawningPoints = new List<spawnPoints>();

    // Start is called before the first frame update
    void Start()
    {
        transformScript = GetComponent<IGB283Transform>();
        DO = shape.GetComponent<DisplayObject>();
        
        //spawns in points at desired positions  
        foreach (spawnPoints SP in spawningPoints)
        {
            //calculating magnitude for each spawn points  
            distanceToTravel = transformScript.getMagnitude(
                transformScript.getVectorFromPoints(SP.startPosition, SP.endPosition));
            DO.end = (float)distanceToTravel; // each clone now has its own magnitude to follow 
            
            //spawning all necessary objects at the desired position
            Instantiate(SP.StartPoint, SP.startPosition, Quaternion.identity);
            Instantiate(SP.StartPoint, SP.endPosition, Quaternion.identity);
            Instantiate(shape, SP.startPosition, Quaternion.identity);
            
            Debug.Log($"magnitude for {shape} " + DO.end);
            
        }
        
        // Debug.Log( transformScript.getVectorFromPoints(spawningPoints[0].startPosition, spawningPoints[0].endPosition));
        // Debug.Log(distanceToTravel);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
