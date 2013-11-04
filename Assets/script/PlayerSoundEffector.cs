using UnityEngine;
using System.Collections;

public class PlayerSoundEffector : MonoBehaviour {

	public AudioClip coinSE;
	public AudioClip damageSE;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//コインの取得を受信する
	void CatchCoin(int amount){
		audio.PlayOneShot(coinSE);
	}

	void ApplyDamage(int amount){
		audio.PlayOneShot(damageSE);
	}
}
