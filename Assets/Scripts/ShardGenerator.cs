using UnityEngine;
using System.Collections;

public class ShardGenerator : MonoBehaviour {

	public GameObject shard;
	public float generationInterval;

	void GenerateShard() {
		int randomXPosition = Random.Range(-45, 45);

		Vector3 position = new Vector3(randomXPosition, 2, 40);

		Instantiate (shard, position, new Quaternion());
	}

	public float GetGenerationInterval () {
		return generationInterval;
	}

	public void SetGenerationInterval(float newInterval) {
		generationInterval = newInterval;
	}
}
