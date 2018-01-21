using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDialogController : DialogControllerBase {

    [SerializeField]
    private Canvas _canvas;

    private bool _update;
    private Collider2D _collision;

    // Use this for initialization
    void Start()
    {
        _canvas.enabled = false;
        _update = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _update = true;
        _collision = collision;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _update = false;
        _collision = null;
    }
    private void Update()
    {
        if (_update)
        {
            if (Input.GetKeyDown(KeyCode.Z) && _canvas.enabled == false)
            {
                _collision.GetComponent<PlayerController>().enabled = false;
                //_collision.GetComponent<Animator>().enabled = false;
                //_canvas.GetComponent<DialogControllerBase>().enabled = true;
                _canvas.enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && _canvas.enabled == true)
            {
                _collision.GetComponent<PlayerController>().enabled = true;
                //_collision.GetComponent<Animator>().enabled = true;
                //_canvas.GetComponent<DialogControllerBase>().enabled = false;
                _canvas.enabled = false;
            }
        }
    }
}
