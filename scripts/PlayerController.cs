using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 15.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;

        transform.Translate(x, y, 0);
    }
}
