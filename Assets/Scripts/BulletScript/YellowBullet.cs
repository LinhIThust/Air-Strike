using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedBullet;
    private Rigidbody2D bullet;
    private void Awake()
    {
        bullet = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        bullet.velocity = new Vector2(0f, speedBullet);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Rock"))
        {
            collision.gameObject.SetActive(false);
            Debug.Log("Va cham voi da");
        }
    }
}
