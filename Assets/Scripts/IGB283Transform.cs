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
    public static Matrix3x3 Translate(float dx, float dy)
    {
        //Create a new matrix
        Matrix3x3 matrix = new Matrix3x3();

        // Set rows of the matrix
        matrix.SetRow(0, new Vector3(1.0f, 0.0f, dx));
        matrix.SetRow(1, new Vector3(0.0f, 1.0f, dy));
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
}
