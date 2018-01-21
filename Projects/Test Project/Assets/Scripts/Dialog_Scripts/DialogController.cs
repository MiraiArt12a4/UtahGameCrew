using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {

    [SerializeField]
    private Canvas _dialogBubble;
    [SerializeField]
    private Text _text;
    [SerializeField]
    private TextAsset _textFile;
    [SerializeField]
    private int _dialogSpeed;

    private Queue<string> _queue = new Queue<string>();

    private const int CHARACTERS = 51;
    private bool _executing;

	// Use this for initialization
	void Start () {
        _dialogBubble.enabled = false;
        _text.supportRichText = false;
        _executing = false;

        string s = _textFile.text;
        string[] sentence = Regex.Split(s, @"(?<=[\.!\?])\s+");
        foreach(string str in sentence)
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
        execute();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CancelInvoke();
        //_dialogBubble.enabled = false;
        if (collision.name == "Pinky")
        {
            _dialogBubble.enabled = false;
        }
    }

    private void execute()
    {
        InvokeRepeating("test", _dialogSpeed, _dialogSpeed);
    }

    private void test()
    {
        _text.text = _queue.Dequeue();
        _queue.Enqueue(_text.text);
    }

    private IEnumerable<string> splitString(string s, int size)
    {
        return Enumerable.Range(0, s.Length/size).Select(i => s.Substring(i*size, size));
    }
}
