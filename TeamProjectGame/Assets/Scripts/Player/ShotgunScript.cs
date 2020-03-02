using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem gunFlash;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            for (int i = 0; i < 12; i++)
            {
                shoot();
            }  
        }
    }
    //raycast method
    void shoot()
    {
        //Plays particle on shoot for gun effect
        gunFlash.Play();
        //declare Raycast for gun
        RaycastHit hit;
        Vector3 Direction = fpsCam.transform.forward;
        Direction.x += Random.Range(-0.1f, 0.1f);
        Direction.y += Random.Range(-0.1f, 0.1f);
        Direction.z += Random.Range(-0.1f, 0.1f);
        if (Physics.Raycast(fpsCam.transform.position, Direction, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Debug.DrawLine(fpsCam.transform.position, hit.point, Color.green);
            enemy target = hit.transform.GetComponent<enemy>();
            //Checks if Raycast hit something for it to takedamage
            if (target != null)
            {
                //calls public command from enemy to take damage
                target.TakeDamage(damage);
            }
        }
    }
}

