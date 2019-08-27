using System.Collections;

using UnityEngine;

public class changesprite : MonoBehaviour
{
    public Sprite mutet;
    public Sprite mutef;

    private void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = mutet;
    }
    void Update()
    {if (FindObjectOfType<audiomanager>().mtf == true)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = mutef;
        if (FindObjectOfType<audiomanager>().mtf == false)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = mutet;

    }
}
