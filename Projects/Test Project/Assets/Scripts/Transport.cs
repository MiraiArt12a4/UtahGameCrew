using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour {

    public string _scene;
	

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(_scene);
    }
}
