using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour {

    public string _scene;
	
    public void OnTriggerStay2D(Collider2D collider)
    {
        if(Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene(_scene);
        }
        
    }
}
