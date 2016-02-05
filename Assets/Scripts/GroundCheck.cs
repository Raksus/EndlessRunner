﻿using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

    private PlayerScript player;

	void Start () {
        player = gameObject.GetComponentInParent<PlayerScript>();
	}

    void OnTriggerEnter2D(Collider2D col) {
        player.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col) {
        player.grounded = false;
    }

    void OnTriggerStay2D(Collider2D col) {
        player.grounded = true;
    }
}
