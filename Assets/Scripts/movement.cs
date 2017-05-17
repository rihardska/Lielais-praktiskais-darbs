using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    float speed = 100.0f;
    public static int movespeed = 275;
    public Vector3 userDirection = Vector3.forward;
   
    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update () {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
        transform.Translate(userDirection * movespeed * Time.deltaTime);

        //robezas
        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(transform.position.y, -65f, 75f);
        clampedPosition.x = Mathf.Clamp(transform.position.x, -75f, 75f);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }
}
