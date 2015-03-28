using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private int health = 3;

	private Vector3 straightVector = new Vector3(0, 0, -10);
	private Vector3 leftVector = new Vector3(5, 0, -10);
	private Vector3 rightVector = new Vector3(-5, 0, -10);
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left")) {
			foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Shard")) {
				gameObject.GetComponent<Rigidbody>().velocity = leftVector;
			}
		} else if (Input.GetKey("right")) {
			foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Shard")) {
				gameObject.GetComponent<Rigidbody>().velocity = rightVector;
			}
		} else if (Input.GetKeyUp ("right") || Input.GetKeyUp ("left")) {
			foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Shard")) {
				gameObject.GetComponent<Rigidbody>().velocity = straightVector;
			}
		}
	}

	public void ReduceHealth(int reducer) {
		health -= reducer;
	}

	public bool isDead() {
		if (health <= 0) {
			return true;
		} else {
			return false;
		}
	}
}
