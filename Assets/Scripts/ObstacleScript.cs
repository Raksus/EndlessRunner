using UnityEngine;
using System.Collections;
using System;

public class ObstacleScript : MonoBehaviour {

    public Vector2 force;

    private Rigidbody2D body;
    private PlayerScript player;

	// Use this for initialization
	void Start () {
        body = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();

    }
	
	// Update is called once per frame
	void Update () {
        
        if (gameObject.transform.localPosition.x < -4.0f) {
            ObjectPool.instance.PoolObject(gameObject);
            gameObject.transform.localPosition = new Vector2(20.0f, -0.6f);
        }


	}


    void FixedUpdate() {
        body.velocity = new Vector2(-10, 0);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player") {
            player.animator.SetBool("Alive", false);
            GameManager.inGame = false;
            player.body.AddForce(new Vector2(500 ,80), ForceMode2D.Force);
            StartCoroutine(Finish());
            Debug.Log("Has muerto");
        }
    }

    private IEnumerator Finish() {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
