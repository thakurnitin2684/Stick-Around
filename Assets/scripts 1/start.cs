using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
    public GameObject startui;
    public void Play()
    {
        FindObjectOfType<audiomanager>().Play("buttonclick");
        startui.SetActive(true);

    }
}
