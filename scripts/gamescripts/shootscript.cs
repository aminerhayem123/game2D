using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootscript : MonoBehaviour
{
    public Transform Gun;
    Vector2 direction;
    public float BulletSpeed;
    public Transform ShootPoint;
    public GameObject Bullet;
    public float fireRate;
    float ReadyForNextShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();

        if(Input.GetMouseButton(0))
        {    
            if(Time.time > ReadyForNextShot)
            {
                ReadyForNextShot = Time.time + 1/fireRate;
                shoot();
            }
        }
    }


    void FaceMouse()
    {
        Gun.transform.right = direction;
    }
    
    void shoot()
    {
        GameObject BulletIns = Instantiate (Bullet,ShootPoint.position,ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
        cractersounds.PlaySound ("gun");
    }
}
