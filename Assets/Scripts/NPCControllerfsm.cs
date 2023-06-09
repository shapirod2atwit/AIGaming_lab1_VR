// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public enum NPCState{
//     Patrol,
//     Attack,
//     Retreat
// }

// public class NPCControllerfsm : MonoBehaviour
// {
//     public GameObject player = GameObject.find("Player");
//     public Transform playerTransform = player.transform;
//     public NPCState currentState = NPCState.Patrol;
//     private float distanceToPlayer;
//     public float attackDistance = 1f;
//     public float retreatDistance = 5f;
//     Vector3 targetPosition;
//     public float speed = 1.0f;

//     void Start(){
//         targetPosition = new Vector3(0,0,0);
//     }
    
//     // Update is called once per frame
//     void Update()
//     {
//         Debug.Log(currentState);
//         distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

//         switch (currentState)
//         {
//             case NPCState.Patrol:
//                 // Code to move the NPC in a patrol pattern here

//                 if (distanceToPlayer <= attackDistance)
//                 {
//                     currentState = NPCState.Attack;
//                 }
//                 break;

//             case NPCState.Attack:
//                 // Code to make the NPC attack the player here
//                 Vector3 direction = (playerTransform.position - transform.position).normalized;
//                 transform.position += direction * speed * Time.deltaTime;

//                 if (distanceToPlayer > attackDistance)
//                 {
//                     currentState = NPCState.Patrol;
//                 }
//                 else if (distanceToPlayer <= retreatDistance)
//                 {
//                     currentState = NPCState.Retreat;
//                 }
//                 break;

//             case NPCState.Retreat:
//                 // Code to make the NPC move away from the player here
//                 this.transform.Translate(targetPosition);

//                 if (distanceToPlayer > retreatDistance)
//                 {
//                     currentState = NPCState.Patrol;
//                 }
//                 break;
//         }
//     }
// }
