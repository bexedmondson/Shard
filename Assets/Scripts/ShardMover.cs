using UnityEngine;
using System.Collections;

public class ShardMover : MonoBehaviour {
	
	public GameObject finalScore;

	public float speed = 5f;
	private new Rigidbody rigidbody;

	void Start () {
		rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = new Vector3(0, 0, -10);
	}

	void Update () {
		if ( rigidbody.position.z < -45 ) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Destroy(gameObject);
			other.GetComponent<PlayerController>().ReduceHealth(1);

			if (other.GetComponent<PlayerController>().isDead()) {
				GameController gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
				gameController.FinishGame();
				//TODO - testing github - remove this code
			}
		}
	}
}
