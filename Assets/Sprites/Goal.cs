using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D colInfo) {

		if (colInfo.tag == "Player") {
			Debug.Log ("GAME WON!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}

	}

}
