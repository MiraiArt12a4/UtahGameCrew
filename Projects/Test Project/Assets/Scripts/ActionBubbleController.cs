using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBubbleController : MonoBehaviour {

    public Canvas _actionBubble;

	// Use this for initialization
	void Start () {
        _actionBubble.enabled = false;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag == "Whatchamacallit")
        {
            _actionBubble.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Whatchamacallit")
        {
            _actionBubble.enabled = false;
        }
    }
}
