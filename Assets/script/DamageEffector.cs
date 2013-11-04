using UnityEngine;
using System.Collections;

public class DamageEffector : MonoBehaviour {

	private bool effectFlag;
	private Color originalColor;


	// Use this for initialization
	void Start () {

		//マテリアルを元来の色に戻しておく
		originalColor = renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		if(effectFlag){

			//マテリアルを赤点滅させる
			renderer.material.color = Color.red * Mathf.Abs(Mathf.Sin(40.0f*Time.time));	
		}
	}

	//ダメージを受信する
	IEnumerator ApplyDamage(){
		//演出をオン
		effectFlag = true;

		//0.3秒間演出を続ける
		yield return new WaitForSeconds(0.3f);

		//演出をオフにして、マテリアルを元に戻す
		effectFlag = false;
		renderer.material.color = originalColor;

	}
}
