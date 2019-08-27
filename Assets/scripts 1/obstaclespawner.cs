
using UnityEngine;

public class obstaclespawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] wallprefab;
    private float timetospawn = 1f;
    public float timebetweenwaves = 1f;
   
    // Use this for initialization
    void Update()
    {
        if (Time.time >= timetospawn)
        {
            spawnblocks();
            timetospawn = Time.time + timebetweenwaves;
        }


    }
    void spawnblocks()
    {
        int raone = Random.Range(0, 3);
        int randomIndex = Random.Range(0, spawnpoints.Length);
        {
            Instantiate(wallprefab[raone], spawnpoints[randomIndex].position, Quaternion.identity);
            
        }
        
    }

}
