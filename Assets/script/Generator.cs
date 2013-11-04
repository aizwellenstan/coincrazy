using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	private float intervalMin = 0.5f;
	private float intervalMax = 1.5f;
	private float coinRate = 0.3f;

	public GameObject coinPrefab;
	public GameObject spikeBallPrefab;


	// Use this for initialization
	IEnumerator Start () {
		while(true){
			// ランダムに間隔をかけておく
			yield return new WaitForSeconds(Random.Range(intervalMin, intervalMax)); 

			//プレハブをランダムに選択する
			GameObject prefab = Random.value < coinRate ? coinPrefab : spikeBallPrefab;

			//生成位置をランダムに決める(半径5.5の円周上)
			float theta  = Random.Range(0.0f,Mathf.PI*2.0f);
			Vector3 position = new Vector3(Mathf.Cos(theta),0.0f,Mathf.Sin(theta))*5.5f;
			position.y = 2.5f;

			//生成する
			Instantiate(prefab,position,Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
