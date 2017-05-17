using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public void restart(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }
    public void reload(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }
}
