using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
	public GameObject Portal;
	void Update() {
		// 포탈UI가 활성화 되었고 키보드 윗키 누를 시 이동
		// 포탈 접촉 > 포탈 활성화 시
		if ( Portal.gameObject.activeSelf == true && Input.GetKeyDown(KeyCode.UpArrow)) {
            switch(Portal.gameObject.name){
				case ("Portal1"):
					// 완전 변경 LoadScene("빌드세팅에서 이름")
					// 새 씬 열기 SceneManager.LoadScene("이름", LoadSceneMode.Additive);
					SceneManager.LoadScene("VillScene");
					break;
				case ("Portal2"):
					SceneManager.LoadScene("MapScene");
					break;
				case ("Portal3"):
					SceneManager.LoadScene("BossScene");
					break;
			}
		}
	}
}
    