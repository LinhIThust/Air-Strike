using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControll : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D plane;
    public float planeSpeed;
    void Start()
    {
        plane = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        PlaneMove();
    }
    private void PlaneMove()
    {
        var xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;
        var yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;
        plane.velocity = new Vector2(xAxis, yAxis);
    }
    

}
