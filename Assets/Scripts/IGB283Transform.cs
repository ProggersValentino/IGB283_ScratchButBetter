using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGB283Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    //returns the matrix inversed
    public static Matrix3x3 GetInverse(Matrix3x3 matrix)
    {
        Matrix3x3 InverseMatrix = new Matrix3x3();

        InverseMatrix = matrix;

        Matrix3x3 inverseMatrixInverse = InverseMatrix.inverse;

        return inverseMatrixInverse;
    }
    
    // Rotate a vertex around the origin
    public static Matrix3x3 Rotate (float angle)
    {
        // Create a new matrix
        Matrix3x3 matrix = new Matrix3x3();

        // Set the rows of the matrix
        matrix.SetRow(0, new Vector3(Mathf.Cos(angle), -Mathf.Sin(angle), 0.0f));
        matrix.SetRow(1, new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0.0f));
        matrix.SetRow(2, new Vector3(0.0f, 0.0f, 1.0f));

        return matrix;
    }

    //Translate a vertex by dx dy
    public static Matrix3x3 Translate(Vector3 offset)
    {
        //Create a new matrix
        Matrix3x3 matrix = new Matrix3x3();

        // Set rows of the matrix
        matrix.SetRow(0, new Vector3(1.0f, 0.0f, offset.x));
        matrix.SetRow(1, new Vector3(0.0f, 1.0f, offset.y));
        matrix.SetRow(2, new Vector3(0.0f, 0.0f, 1.0f));

        return matrix;
    }

    //Scale a vertex by a factor of sx and sy
    public static Matrix3x3 Scale(float sx, float sy)
    {
        //Create a new matrix
        Matrix3x3 matrix = new Matrix3x3();

        // Set rows of the matrix
        matrix.SetRow(0, new Vector3(sx, 0.0f, 0.0f));
        matrix.SetRow(1, new Vector3(0.0f, sy, 0.0f));
        matrix.SetRow(2, new Vector3(0.0f, 0.0f, 1.0f));

        return matrix;
    }
    
    //calculate magnitude from 
    public double getMagnitude(Vector3 V1)
    {
        double magnitude = Math.Sqrt((V1.x * V1.x) + (V1.y * V1.y) + (V1.z * V1.z));

        return magnitude;
    }
    
    //returns the vector from points 
    public Vector3 getVectorFromPoints(Vector3 Q, Vector3 P)
    {
        Vector3 V = P - Q;

        return V;
    }
    
}
