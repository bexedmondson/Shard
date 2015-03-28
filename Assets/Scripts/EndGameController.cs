using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGameController : MonoBehaviour {

	public Text endText;

	void Start () {
		FinalScoreStorer finalScoreStorer = GameObject.FindWithTag("Finish").GetComponent<FinalScoreStorer>();
		string finalScore = finalScoreStorer.finalScore;

		endText.text = "YOU DIED. YOUR SCORE WAS " + finalScore +"\nHIT SPACE TO TRY AGAIN";
	}

	void Update () {
		if (Input.GetKey("space")) {
			Application.LoadLevel("MainScene");
		}
	}
}
