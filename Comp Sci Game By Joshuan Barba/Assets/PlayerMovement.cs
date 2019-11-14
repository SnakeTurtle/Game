
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb2;
    
	// Use this for initialization
	void Start () {
        new Vector2(0, 250);
        rb2 = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown("d"))
        {
            rb2.AddForce(new Vector3(500, 0, 0)); 
        }

        if (Input.GetKeyDown("w"))
        {
            rb2.AddForce(new Vector3(0, 500, 0));
        }

        if (Input.GetKeyDown("a"))
        {
            rb2.AddForce(new Vector3(-500, 0, 0));
        }

        if (Input.GetKeyDown("s"))
        {
            rb2.AddForce(new Vector3(0, -500, 0));
        }




    }
}
