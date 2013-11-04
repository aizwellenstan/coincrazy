using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	private int score = 0;
	public GUISkin skin;

	// Use this for initialization
	void Start () {
		GetComponent<GameOverScreen>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<GameOverScreen>().enabled = false;
	}

	void EndGame(int endScore){
		Debug.Log("test");
		score = endScore;
		GetComponent<GameOverScreen>().enabled = true;
	}

	void OnGUI(){
		Debug.Log("over");
		GUI.skin = skin;

		int sw = Screen.width;
		int sh = Screen.height;

		// "GAME OVER!"の文字表示。スタイル"gameover"を使う。
		GUI.Label(new Rect(0.0f, 0.2f * sh, sw, 0.3f * sh), "GAME OVER!", "gameover");
		// "SCORE: 得点"の文字表示。スタイル"result"を使う。
		GUI.Label(new Rect(0.0f, 0.5f * sh, sw, 0.3f * sh), "SCORE: " + score.ToString(), "result");
	}
}
