using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	public GUISkin skin;

	private Quaternion originalRotation; // タイトル文字の元の姿勢。

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			Application.LoadLevel("Game");
		}
	}

	void OnGUI(){
		int sw = Screen.width;
		int sh = Screen.height;
		GUI.skin = skin;

		// メッセージをスタイル"title"を使って文字表示する。
		GUI.Label(new Rect(0.0f, 0.6f * sh, sw, 0.4f * sh), "PRESS SPACE TO START", "title");
	}
}
