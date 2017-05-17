using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zaude : MonoBehaviour {


    public Transform Canvas;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "Planet_A")
        {
            Canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
