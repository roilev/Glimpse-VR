using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public KeyCode forward = KeyCode.UpArrow;
    public KeyCode backward = KeyCode.DownArrow;
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;

    public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update () {
        if (Input.GetKey(forward)) {
            transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(backward))
        {
            transform.Translate(0.0f, 0.0f, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(right))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(left))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

		
	}
}
