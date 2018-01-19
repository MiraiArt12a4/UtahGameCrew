using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class puzzle1Controller : PuzzleControllerBase {

    public string _map;
    public int _height;
    public int _width;

    [SerializeField]
    private Image _highlight;
    [SerializeField]
    private float _pixelHeight;
    [SerializeField]
    private float _pixelWidth;

    private int _y;
    private int _x;

	// Use this for initialization
	void Start () {
        _x = 0;
        _y = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
        {
            if(_x > 0)
            {
                _highlight.rectTransform.position = new Vector3(_highlight.rectTransform.position.x - _pixelWidth, _highlight.rectTransform.position.y);
                _x--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (_y > 0)
            {
                _highlight.rectTransform.position = new Vector3(_highlight.rectTransform.position.x, _highlight.rectTransform.position.y + _pixelHeight);
                _y--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (_y < _height - 1)
            {
                _highlight.rectTransform.position = new Vector3(_highlight.rectTransform.position.x, _highlight.rectTransform.position.y - _pixelHeight);
                _y++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (_x < _width - 1)
            {
                _highlight.rectTransform.position = new Vector3(_highlight.rectTransform.position.x + _pixelWidth, _highlight.rectTransform.position.y);
                _x++;
            }
        }
    }
}
