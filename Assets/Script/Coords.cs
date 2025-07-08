using UnityEngine;

public class Coords
{
    float x, y, z;
    public Coords(float _x, float _y)
    {
        x = _x;
        y = _y;
        z = -1; // initial depth in z as -1
    }

    //draw line method
    static public void DrawLine(Coords startPos, Coords endPos, float width, Color colour)
    {
        GameObject line = new GameObject("Line" + startPos.ToString() + endPos.ToString());
        //Add component to render the line
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        //Create and assign material to line renderer
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;//Assign color to line
        lineRenderer.positionCount = 2;//two points in line
        //Define start position of line
        lineRenderer.SetPosition(0, new Vector3(startPos.x, startPos.y, startPos.z));
        //Define start position of line
        lineRenderer.SetPosition(1, new Vector3(endPos.x, endPos.y, endPos.z));
        //Define line width
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

static public void DrawPoint(Coords pointPosition, float width, Color colour)
    {
        GameObject line = new GameObject("Line" + pointPosition.ToString());
        //Add component to render the line
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        //Create and assign material to line renderer
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;//Assign color to line
        lineRenderer.positionCount = 2;//two points in line

        //Define start position of line
        lineRenderer.SetPosition(0, new Vector3(pointPosition.x - width/3.0f, pointPosition.y-width/3.0f, pointPosition.z));
        //Define start position of line
        lineRenderer.SetPosition(1, new Vector3(pointPosition.x + width/3.0f, pointPosition.y+width/3.0f, pointPosition.z));

        //Define line width
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }}
