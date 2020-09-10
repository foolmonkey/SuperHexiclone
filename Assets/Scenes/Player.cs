using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    float moveSpeed = 300.0f;
    float movement = 0.0f;

    // Start is called before the first frame update
    void Start () {
    }

    private void FixedUpdate () {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    // Update is called once per frame
    void Update () {
        movement = Input.GetAxisRaw ("Horizontal");
    }
}