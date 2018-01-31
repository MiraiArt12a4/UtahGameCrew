using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle3Controller : PuzzleControllerBase
{
    public List<Sprite> _list;

    [SerializeField]
    private Image _dialImage1;
    [SerializeField]
    private Image _dialImage2;
    [SerializeField]
    private Image _dialImage3;

    void Start () {

       foreach(Sprite s in _list)
        {

        }
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

        }
    }

    private void TransitionDials()
    {

    }
}

