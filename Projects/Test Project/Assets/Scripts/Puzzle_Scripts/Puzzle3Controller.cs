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

    private int _currentDial;
    private int _dialIndex1;
    private int _dialIndex2;
    private int _dialIndex3;

    void Start () {
        _currentDial = 0;
        _dialIndex1 = 0;
        _dialIndex2 = 0;
        _dialIndex3 = 0;
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _currentDial--;
            if(_currentDial < 0)
            {
                _currentDial = 2;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            GetNextDialIndex(_currentDial, true);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GetNextDialIndex(_currentDial, false);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _currentDial++;
            if (_currentDial > 2)
            {
                _currentDial = 0;
            }
        }
    }

    private void GetNextDialIndex(int index, bool isNext)
    {
        switch (index)
        {
            case 0:
                if(isNext)
                {
                    _dialIndex1++;
                    if (_dialIndex1 > _list.Count - 1)
                    {
                        _dialIndex1 = 0;
                    }
                }
                else
                {
                    _dialIndex1--;
                    if (_dialIndex1 < 0)
                    {
                        _dialIndex1 = _list.Count - 1;
                    }
                }
                Debug.Log(_dialIndex1);
                _dialImage1.sprite = _list[_dialIndex1];
                break;

            case 1:
                if (isNext)
                {
                    _dialIndex2++;
                    if (_dialIndex2 > _list.Count - 1)
                    {
                        _dialIndex2 = 0;
                    }
                }
                else
                {
                    _dialIndex2--;
                    if (_dialIndex2 < 0)
                    {
                        _dialIndex2 = _list.Count - 1;
                    }
                }
                Debug.Log(_dialIndex2);
                _dialImage2.sprite = _list[_dialIndex2];
                break;

            case 2:
                if (isNext)
                {
                    _dialIndex3++;
                    if (_dialIndex3 > _list.Count - 1)
                    {
                        _dialIndex3 = 0;
                    }
                }
                else
                {
                    _dialIndex3--;
                    if (_dialIndex3 < 0)
                    {
                        _dialIndex3 = _list.Count - 1;
                    }
                }
                Debug.Log(_dialIndex3);
                _dialImage3.sprite = _list[_dialIndex3];
                break;
        }

    }
}

