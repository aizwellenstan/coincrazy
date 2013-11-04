using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float walkSpeed = 3.0f;
	private float jumpSpeed = 8.0f;
	private float gravity = 20.0f;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		animation["Walk"].speed = 2.0f; // 再生速度
		// animation.CrossFade("Walk");
		// yield return new WaitForSeconds(4.0f);  // 中断。2.5秒後に処理再開。
		// animation.CrossFade("Crouch");
		// yield return new WaitForSeconds(4.0f);  // 中断。2.5秒後に処理再開。
		// animation.CrossFade("Idle");
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController col = (CharacterController)GetComponent("CharacterController");

		//接地中のみ行う処理	
		if(col.isGrounded){
			velocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
			velocity *= walkSpeed;

			//スピードがあれば	
			if(velocity.magnitude > 0.5){
				
				//歩行モードに切り替えつつ、進行方向に旋回する
				animation.CrossFade("Walk",0.1f);
				transform.LookAt(transform.position+velocity);
			}else if(Input.GetButtonDown("Jump")){
				velocity.y = jumpSpeed;
				animation.Play("Jump");	
			}else{
				animation.CrossFade("Idle",0.1f);	
			}



		}
		//重力による下方向への加速
		velocity.y -= gravity * Time.deltaTime;

		//キャラクターコントローラの移動
		col.Move(velocity*Time.deltaTime);
	}

	// void OnTriggerEnter(Collider other) {
	// 	Debug.Log("Year!");
	// }	
}
