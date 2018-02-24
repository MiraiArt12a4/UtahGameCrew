using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle2Controller : PuzzleControllerBase {

    public List<Sprite> _list;
    public List<Image> _dialList;

    [SerializeField]
    private int _solution;
    private List<int> _dialIndexes;
    private int _currentDial;
    

    void Start()
    {
        _dialIndexes = new List<int>();
        _currentDial = 0;

        foreach (Image i in _dialList)
        {
            _dialIndexes.Add(0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _currentDial--;
            if (_currentDial < 0)
            {
                _currentDial = _dialList.Count - 1;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _dialIndexes[_currentDial] = bounds(_dialIndexes[_currentDial] + 1);

            _dialList[_currentDial].sprite = _list[_dialIndexes[_currentDial]];
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _dialIndexes[_currentDial] = bounds(_dialIndexes[_currentDial] - 1);
            _dialList[_currentDial].sprite = _list[_dialIndexes[_currentDial]];
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _currentDial++;
            if (_currentDial > _dialList.Count - 1)
            {
                _currentDial = 0;
            }
        }
    }

    private int bounds(int i)
    {
        if (i < 0)
        {
            return _list.Count - 1;
        }
        else if (i > _list.Count - 1)
        {
            return 0;
        }
        else
        {
            return i;
        }
    }
}
