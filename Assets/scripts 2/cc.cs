using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc : MonoBehaviour
{ public Color[] colors;
    public float Speed = 5;
    Camera _cam;int number=1;
    // Start is called before the first frame update
    void Start()
    {

        
        
            _cam = GetComponent<Camera>();

            
            _cam.backgroundColor=colors[0];
        
    }
    
    // Update is called once per frame
    void Update()
    {
      
        if (FindObjectOfType<playermovement>().count>number*3)
        {
            Invoke("cchange", 0.3f);
       
            if(number<7)
            number++;
        }
    }int numbe = 1;
    void cchange()
    {
        _cam.backgroundColor = colors[numbe];
        if (numbe < 7)
            numbe++;
    }
   
}
