using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControll : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed;
    private Material material;
    private Vector2 offset = Vector2.zero;
    private void Awake()
    {
        material=GetComponent<Renderer>().material;
    }
    void Start()
    {
        var heighBG = Camera.main.orthographicSize * 2f;
        var widthBG = heighBG * Screen.width / Screen.height;
        transform.localScale = new Vector3(widthBG, heighBG, 0);
        offset = material.GetTextureOffset("_MainTex");

    }

    // Update is called once per frame
    void Update()
    {
        offset.y += scrollSpeed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
