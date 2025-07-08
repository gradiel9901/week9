using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coords startPointX = new Coords(-160, 0);
    Coords endPointX = new Coords(160, 0);
    Coords startPointY = new Coords(0, -100);
    Coords endPointY = new Coords(0, 100);

    // 10-point upside-down triangle-like Capricorn constellation
    Coords[] pointArray =
    {
        new Coords(-60f, 40f),   // 0 - top left
        new Coords(-35f, 45f),   // 1 - mid top left
        new Coords(-15f, 35f),   // 2 - inner top left
        new Coords(0f, 30f),     // 3 - center top
        new Coords(15f, 35f),    // 4 - inner top right
        new Coords(35f, 45f),    // 5 - mid top right
        new Coords(60f, 40f),    // 6 - top right
        new Coords(30f, 0f),     // 7 - mid right slope
        new Coords(0f, -50f),    // 8 - bottom tip
        new Coords(-30f, 0f),    // 9 - mid left slope
    };

    void Start()
    {
        // Axes
        Coords.DrawLine(startPointX, endPointX, 1.5f, Color.red);
        Coords.DrawLine(startPointY, endPointY, 1.5f, Color.green);

        // Star points
        foreach (var p in pointArray)
        {
            Coords.DrawPoint(p, 5f, Color.yellow);
        }

        // Constellation lines - forming an upside-down triangle pattern
        Coords.DrawLine(pointArray[0], pointArray[1], 1.5f, Color.white);
        Coords.DrawLine(pointArray[1], pointArray[2], 1.5f, Color.white);
        Coords.DrawLine(pointArray[2], pointArray[3], 1.5f, Color.white);
        Coords.DrawLine(pointArray[3], pointArray[4], 1.5f, Color.white);
        Coords.DrawLine(pointArray[4], pointArray[5], 1.5f, Color.white);
        Coords.DrawLine(pointArray[5], pointArray[6], 1.5f, Color.white);
        Coords.DrawLine(pointArray[6], pointArray[7], 1.5f, Color.white);
        Coords.DrawLine(pointArray[7], pointArray[8], 1.5f, Color.white);
        Coords.DrawLine(pointArray[8], pointArray[9], 1.5f, Color.white);
        Coords.DrawLine(pointArray[9], pointArray[0], 1.5f, Color.white); // closes triangle
    }

    void Update()
    {

    }
}
