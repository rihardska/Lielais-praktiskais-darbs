﻿using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
    
    public GameObject Bullet_Emitter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;

    public AudioClip clip;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            Temporary_Bullet_Handler.transform.Rotate(Vector3.down);

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            //Destroy(Temporary_Bullet_Handler, 5.0f);

        }

    }

}