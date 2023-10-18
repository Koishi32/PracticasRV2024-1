using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DrunkBehaviour : MonoBehaviour
{
    Animator Animator;
    NavMeshAgent myNavMeshAgent;
    public Rigidbody bullet;
    public Transform Player;
    Vector3 Destination;
    // Start is called before the first frame update
    void Start()
    {
        Animator = this.gameObject.GetComponent<Animator>();
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        Animator.SetBool("IsRuning", true);
        //myNavMeshAgent.destination=(Player.transform.position);
        Destination = myNavMeshAgent.destination;
    }

    private void Update()
    {
        //myNavMeshAgent.SetDestination(Player.transform.position);
        if (Vector3.Distance(Destination, Player.position) > 1.0f)
        {
            Destination = Player.position;
            myNavMeshAgent.destination = Destination;
        }

    }
    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.gameObject.name);
        if (collision.collider.tag == "Projectile") {
            Debug.Log("Hit");
            Animator.SetTrigger("Pain");
            //Animator.SetBool("IsRuning", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PlayerHit");
            Animator.SetTrigger("Punch");
            //Animator.SetBool("IsRuning", false);
        }
    }
    public void OnPointerEnter()
    {
        
    }


    public void OnPointerExit()
    {
        
    }

    public void ResumeRuning() {
        Animator.SetBool("IsRuning", true);
    }

    public void OnPointerClick()
    {
        if (bullet!= null) {
            Debug.Log("Log");
            Rigidbody clone;
            clone = Instantiate(bullet, Player.position, Player.rotation);
            clone.velocity = Player.TransformDirection(Player.forward * 10);
            Destroy(clone.gameObject,3.0f);
        }
    }
#if UNITY_EDITOR
    private void OnMouseDown()
    {
        if (bullet != null)
        {
            Debug.Log("Log");
            Rigidbody clone;
            clone = Instantiate(bullet, Player.position, Player.rotation);
            clone.velocity = Player.TransformDirection(Player.forward * 1.5f);
            Destroy(clone.gameObject,1.5f);
        }
    }
#endif

}
