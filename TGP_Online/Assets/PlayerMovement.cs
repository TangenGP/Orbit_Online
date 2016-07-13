using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 6f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxisRaw("Vertical") * Time.deltaTime, 0f);
	}
}
