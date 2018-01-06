using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {

    [SerializeField]
    Canvas _dialogBubble;
    [SerializeField]
    Text _text;
    [SerializeField]
    TextAsset _textFile;
	// Use this for initialization
	void Start () {
        _dialogBubble.enabled = false;
        _text.supportRichText = false;
        _text.text = _textFile.text;
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //_dialogBubble.enabled = true;
        _text.supportRichText = true;
        if (collision.name == "Pinky")
        {
            _dialogBubble.enabled = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        //_dialogBubble.enabled = false;
        if (collision.name == "Pinky")
        {
            _dialogBubble.enabled = false;
        }
    }
}
