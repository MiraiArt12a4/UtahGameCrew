using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isometric : MonoBehaviour {

    public float _floorHeight;
    private readonly float angle = Mathf.Tan(Mathf.PI / 4);

    private float _spriteLowerBound;

	void Start () {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteLowerBound = spriteRenderer.bounds.size.y * 0.5f;
	}
	

	void LateUpdate () {
        float z = (transform.position.y - _spriteLowerBound + _floorHeight) * angle;
        transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}
}
