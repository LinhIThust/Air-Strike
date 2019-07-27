using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    private bool canShoot = true;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject bullet2;
    [SerializeField]
    private GameObject plane;
    [SerializeField]
    private float timeShoot =0.2f;
    private void Start()
    {
        StartCoroutine(Shoot());
    }
    private void Update()
    {
        
    }

    public void PauseGame()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumseGame()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            canShoot = false;
            Vector3 tmp = plane.transform.position;
            tmp.y += 0.7f;
            Instantiate(bullet, tmp, Quaternion.identity);
            tmp.y -= 0.3f;
            tmp.x += 0.5f;
            Instantiate(bullet2, tmp, Quaternion.identity);
            yield return new WaitForSeconds(timeShoot);
            canShoot = true;
        }
       

    }
}
