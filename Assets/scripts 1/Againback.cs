using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Againback: MonoBehaviour {
    //the go button functionS
	public void Goback()
    {
        FindObjectOfType<audiomanager>().Play("buttonclick");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
