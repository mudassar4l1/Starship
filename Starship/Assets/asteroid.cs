using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
	public float speed = 5.0f;
	private Rigidbody2D rb;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(speed, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
