using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour {
    GameObject obstacle;

    public static bool inGame;

    // Use this for initialization
    void Start () {
        inGame = true;
        StartCoroutine(SpawnObstacle());
    }
	
	// Update is called once per frame
	void Update () {

	}

    private IEnumerator SpawnObstacle() {
        while (inGame) {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0,2.0f));
            ObjectPool.instance.GetObjectForType("Obstacle", true);
        }
        
    }
}
