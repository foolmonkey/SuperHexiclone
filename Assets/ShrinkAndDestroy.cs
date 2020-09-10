using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndDestroy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0.0f, 360.0f);
        transform.localScale = Vector3.one * 10.0f;

    }

    // Update is called once per frame
    void Update()
    {
        //Scale this game object
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        //Once tiny, delete
        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }
    }
}
