using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class ontiuchplay : MonoBehaviour {
    
	public void ontouchstart()
    {
       // if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        //{
          //  closeui.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        //}
    }
}
