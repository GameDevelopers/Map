using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
	public GameObject Portal;
	void Update() {
		// ��ŻUI�� Ȱ��ȭ �Ǿ��� Ű���� ��Ű ���� �� �̵�
		// ��Ż ���� > ��Ż Ȱ��ȭ ��
		if ( Portal.gameObject.activeSelf == true && Input.GetKeyDown(KeyCode.UpArrow)) {
            switch(Portal.gameObject.name){
				case ("Portal1"):
					// ���� ���� LoadScene("���弼�ÿ��� �̸�")
					// �� �� ���� SceneManager.LoadScene("�̸�", LoadSceneMode.Additive);
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
    