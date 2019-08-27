using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yesback : MonoBehaviour
{

    public void Goback()
    {
        FindObjectOfType<audiomanager>().Play("buttonclick");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

