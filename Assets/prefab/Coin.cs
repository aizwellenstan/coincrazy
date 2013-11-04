using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	

	void OnTriggerEnter(Collider other) {
		//CatchCoinメッセージを送信する
		other.gameObject.SendMessage("CatchCoin",1);
		// if(other.gameObject.tag == "Player"){
		// 	Debug.Log("test");
		// }
		//Debug.Log("test");
		//自分は消える
		Destroy(gameObject);
	}	


}
