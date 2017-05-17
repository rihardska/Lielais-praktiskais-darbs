using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour
{
    public AudioClip clip;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 800f;

    }
    public GameObject explosion; // drag your explosion prefab here

    void OnCollisionEnter()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject); // destroy the grenade
        Destroy(expl, 3); // delete the explosion after 3 seconds
    
    }

}
