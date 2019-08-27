using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour
{
    public bool once = false;
    public float jumpforce = 10f;
    public float speed = 10f;
    public float spee = 10f;
    public float slowness = 10f;
    public float speed22 = 10f;
    public Rigidbody2D rb;
    public Rigidbody2D wall;
    public Transform player2;
    public float restartdelay = 1f;
    public float restartdelay2 = 0.4f;
   // public float restartdelay3 = 2.4f;
    
    int flag = 0;
    public int count = 0;
    public string store;
    public string store2;
    private bool facingright = false;
    public GameObject restartlevelui;
    bool error = false;
    readonly bool cp;
    bool adbool = true;
  

    private void Start()
    { 
        Time.timeScale = 1f;
       // flag = Random.Range(0, 2);
        rb.gravityScale = 2; count = 0;
        if (flag == 1)
        {
            flip();
            facingright = true;
        }

        //for the first jump
        FindObjectOfType<audiomanager>().Play("jump");
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Force);


        if (flag == 1)
        {
            rb.velocity = new Vector2(speed, 0);
            if (facingright == false)
                flip();

        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
            if (facingright == true)
                flip();
        }
    }

    // Update is called once per frame
    void Update()

    {
        

         if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        //  Touch touch = Input.GetTouch(0);
       // if(Input.touchCount>0)
        // if (touch.phase == TouchPhase.Began)
        {   if(error==false)
            FindObjectOfType<audiomanager>().Play("jump");

            rb.gravityScale = 2;



            rb.velocity = Vector3.zero;
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Force);

            
            if (flag == 1)
            { rb.velocity = new Vector2(speed, 0);
                if (facingright == false)
                    flip();

            }
            else { rb.velocity = new Vector2(-speed, 0);
                if (facingright == true)
                    flip();
            }

        }


        if (player2.position.x >= 4)
        {
           // FindObjectOfType<audiomanager>().Play("playerout");
            Invoke("Restart", restartdelay2);
        }
        if (player2.position.x <= -4)
        {
           // FindObjectOfType<audiomanager>().Play("playerout");
            Invoke("Restart", restartdelay2);
        }
        if (player2.position.y <= -5)
        {
           // FindObjectOfType<audiomanager>().Play("playerout");
            Invoke("Restart", restartdelay2);
        }
        
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == "wall")
        {     if(other.name ==store)
            {
                
                Debug.Log("there is repeat");
                Debug.Log(count);
               // Invoke("Restart", restartdelay2);
            }
            if (error == false)
            {  
                count++;
            }
            if (flag == 1)
            {
                flag = 0;
               
                rb.velocity = Vector3.zero;
                rb.gravityScale = 0;
                rb.velocity = new Vector2(0, -spee);
               // rb.AddForce(Vector2.down * speed * Time.deltaTime,ForceMode2D.Force);
                
                // rb.velocity = new Vector2(-speed, 0);

            }
            else
            {
                flag = 1;
                rb.velocity = Vector3.zero;
                rb.gravityScale = 0;
                rb.velocity = new Vector2(0, -spee);
                //rb.velocity = new Vector2(speed, 0);

            }

             store = other.name;
        }
        if (other.tag == "Finish")
        { 
            if (other.name == store2)
            {  //if(once==false)
                //FindObjectOfType<audiomanager>().Play("playerout");
                //once = true;
             
                Invoke("Restart", restartdelay2);

            }if (once == false)
            {
                FindObjectOfType<audiomanager>().Play("playerout");
                once = true;
            }
            StartCoroutine(RestartLevel());
           
            restartlevelui.SetActive(true); error = true;
            store2 = other.name;
            if (count > 3)
            {
                if (count > 8)
                { if (count > 15)
                        FindObjectOfType<AdScripts>().UserOptToWatchAd();
                  else
                    FindObjectOfType<AdScripts>().GameOver();
                }
                else
                {
                    if (adbool == true)
                    {
                        FindObjectOfType<AdScripts>().GameOver();
                        adbool = !adbool;
                    }
                }
            }
            //   Invoke("Restart", restartdelay); 
        }
    }
    public void Restart()
    { 
       // FindObjectOfType<audiomanager>().Play("playerout");
        restartlevelui.SetActive(true);error = true;
        if (count > 3)
        {
            if (count > 8)
            {
                if (count > 15)
                    FindObjectOfType<AdScripts>().UserOptToWatchAd();
                else
                    FindObjectOfType<AdScripts>().GameOver();
            }
            else
            {
                if (adbool == true)
                {
                    FindObjectOfType<AdScripts>().GameOver();
                    adbool = !adbool;
                }
            }
        }
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    IEnumerator RestartLevel()
    {
        
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      
        restartlevelui.SetActive(true);error = true;
    }
    void flip()
    {
        facingright = !facingright;
        Vector3 scalar = transform.localScale;
        scalar.x *= -1;
        transform.localScale = scalar;

    }
   
    }


