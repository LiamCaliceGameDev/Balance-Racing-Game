using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D colInfo) {
		if (colInfo.tag == "Collidable") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

}
