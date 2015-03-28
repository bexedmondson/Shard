using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	private Time startTime;

	public float generationInterval = 3f;
	public float difficultyIncrease = 0.9f;

	public Text textTimer;
	public FinalScoreStorer finalScoreStorer;

	void Start () {
		//final score can't die between levels
		//finalScore = GameObject.FindWithTag("Finish");


		//create hazards
		ShardGenerator shardGenerator = GetComponent<ShardGenerator>();
		shardGenerator.SetGenerationInterval(generationInterval);
		shardGenerator.InvokeRepeating ("GenerateShard", 0f, generationInterval);

		//start difficulty increasing
		InvokeRepeating("IncreaseDifficulty", 5f, 5f);
	}

	void OnGUI() {
		textTimer.text = "Score: " + Time.timeSinceLevelLoad.ToString("F2");
	}

	void Update () {
	}

	void IncreaseDifficulty() {
		generationInterval *= difficultyIncrease;
	}

	public void FinishGame() {
		finalScoreStorer = GameObject.FindWithTag("Finish").GetComponent<FinalScoreStorer>();
		finalScoreStorer.finalScore = textTimer.text;
		DontDestroyOnLoad(finalScoreStorer);

		Application.LoadLevel("EndScene");
	}
}
