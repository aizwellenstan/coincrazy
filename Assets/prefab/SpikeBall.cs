using UnityEngine;
using System.Collections;

public class SpikeBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		//CatchCoinメッセージを送信する
		other.gameObject.SendMessage("ApplyDamage",10);
		//Debug.Log("testtest");
		//自分は消える
		Destroy(gameObject);
	}
}
