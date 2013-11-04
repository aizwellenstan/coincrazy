using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {

	public int life = 100;
	public int score = 0;
	public GUIStyle labelstyle;
	public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//コインの取得を受信する
	void CatchCoin(int amount){
		score += amount;
	}

	void ApplyDamage(int amount){
		life -= amount;

		//lifeが０以下になったら破棄	
		if(life <= 0){
			Destroy(transform.parent.gameObject);	

			// Game Controllerにゲーム終了を通知する。
			GameObject.FindWithTag("GameController").SendMessage("EndGame", score);

		}
	}

	void OnGUI()
	{
		// GUIスキンの設定。
		GUI.skin = skin;

		Rect leftrect = new Rect(0.0f,0.0f,Screen.width/2,Screen.height);
		Rect rightrect = new Rect(Screen.width/2,0.0f,Screen.width,Screen.height);

		GUI.Label(leftrect, "LIFE: " + life.ToString(), "life");

		// "SCORE: 得点"をスタイル"score"で文字表示する。
		// "score"スタイルにより右上寄せになる。
		GUI.Label(rightrect, "SCORE: " + score.ToString(), "score");
	}	
}
