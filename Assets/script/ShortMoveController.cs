using UnityEngine;
using System.Collections;

public class ShortMoveController : MonoBehaviour {

	private float velocity = 8.0f;//移動速度
	private float moveDelay = 1.0f;//移動までの遅延時間
	private float sustainTime = 3.0f;//消滅までの時間

	// Use this for initialization
	IEnumerator Start () {

		yield return new WaitForSeconds(moveDelay);  // 登場から移動までウェイトをかけておく
		GameObject player = GameObject.FindWithTag("Player");

		//playerがみつかれば	
		if(player != null){
			Vector3 direction = (player.transform.position - transform.position).normalized;
			rigidbody.AddForce(direction*velocity,ForceMode.VelocityChange);

		}
		yield return new WaitForSeconds(sustainTime);  // 消滅まで時間を置く

		//時間切れで死亡
		Destroy(gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
