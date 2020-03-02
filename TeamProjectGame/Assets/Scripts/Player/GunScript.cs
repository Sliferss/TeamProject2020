using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
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
            shoot();
        }
    }
    //raycast method
    void shoot ()
    {
        //Plays particle on shoot for gun effect
        gunFlash.Play();
        //declare Raycast for gun
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

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
