using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour {

    public Animator _animator;
    public Animations _currentAnimation;
	public enum Animations
    {
        Idle,
        LeftWalk,
        RightWalk,
        UpWalk,
        DownWalk
    }

	void LateUpdate () {
		if(Input.GetKey(KeyCode.A))
        {
            transition(Animations.LeftWalk, "Pinky_Walk_Left");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transition(Animations.UpWalk, "Pinky_Walk_Up");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transition(Animations.DownWalk, "Pinky_Walk_Down");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transition(Animations.RightWalk, "Pinky_Walk_Right");
        }
    }

    public void transition(Animations anim, string name)
    {
        if(_currentAnimation != anim)
        {
            _animator.Play(name);
            _currentAnimation = anim;
        }
    }
}
