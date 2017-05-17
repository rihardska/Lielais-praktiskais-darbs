using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour {

    public GameObject prefab;

    public Vector3 center;
    public Vector3 size;

	// Use this for initialization
	void Start () {
        center = transform.position;
        for(int i = 0; i < 200; i++)
        {
            spawn();
        }
    
        

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Q))
            spawn();
	}

    public void spawn()
    {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Instantiate(prefab, pos, Quaternion.identity);

    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}
