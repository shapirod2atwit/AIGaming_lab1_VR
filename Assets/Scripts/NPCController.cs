using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform playerTransform;
    private int xcount;
    private Transform[] transforms;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // transforms = new Transform[5];
        // GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag ("waypoint");
        // for (int i = 0; i < transforms.Length; i++) {
        //     transforms[i] = taggedObjects[i].transform;
        // }
        // xcount = Random.Range(0, 5);
    }

    // Define AI behavior for the characters
    void Update()
    {
        // if(transform.position == transforms[xcount].position){
        //     xcount = Random.Range(0, 5);
        // }
            
        // Implement Simple AI to Move towards the player
        // Debug.Log("Distance from player: " + Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, this.transform.position));
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            GameController.npcScore--;
            collision.gameObject.SetActive(false);
        }
    }

}
