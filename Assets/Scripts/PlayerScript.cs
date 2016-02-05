using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public bool grounded;
    public Vector2 jumpPower;

    public Rigidbody2D body;
    public Animator animator;

	void Start () {
        body = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

        animator.SetBool("Alive", true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump") && grounded) {
            body.AddForce(jumpPower, ForceMode2D.Impulse);
        }

        animator.SetBool("Grounded", grounded);
	}
}
