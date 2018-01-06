using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {

    [SerializeField]
    private Canvas _dialogBubble;
    [SerializeField]
    private Text _text;
    [SerializeField]
    private TextAsset _textFile;

    private Queue<string> _queue = new Queue<string>();

    private const int CHARACTERS = 51;

	// Use this for initialization
	void Start () {
        _dialogBubble.enabled = false;
        _text.supportRichText = false;

        string s = _textFile.text;
        string[] sep = s.Split('&');
        foreach(string str in sep)
        {
            _queue.Enqueue(str);
        }
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _text.text = _queue.Dequeue();
        _text.supportRichText = true;
        if (collision.name == "Pinky")
        {
            _dialogBubble.enabled = true;
        }
        _queue.Enqueue(_text.text);
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
