using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBox : MonoBehaviour
{
    // Start is called before the first frame update
    private float scaleValue;
    private float minX, maxX, minY, maxY;
    void Start()
    {
        scaleValue = transform.localScale.x;
        Vector3 box = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minX = -box.x+ scaleValue;
        maxX = box.x - scaleValue;

        minY = -box.y + scaleValue;
        maxY = box.y- scaleValue;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = transform.position;
        if (tmp.x < minX) tmp.x = minX;
        if (tmp.x > maxX) tmp.x = maxX;
        if (tmp.y < minY) tmp.y = minY;
        if (tmp.y > maxY) tmp.y = maxY;
        transform.position = tmp;

    }
}
