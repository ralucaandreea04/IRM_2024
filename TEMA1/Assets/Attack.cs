using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterInteraction : MonoBehaviour
{
    public GameObject myObject1, myObject2;
    public UnityEvent onTrack;
    public UnityEvent onLost;  

    private Animator myAnimator1, myAnimator2;
    public float distance;

    void Start()
    {
        myAnimator1 = myObject1.GetComponent<Animator>();
        myAnimator2 = myObject2.GetComponent<Animator>();
        print("Start");
    }

    void Update()
    {
        if (myObject1.activeSelf && myObject2.activeSelf)
        {
            float currentDistance = Vector3.Distance(myObject1.transform.position, myObject2.transform.position);
            print("Distance: " + currentDistance);
            if (currentDistance < distance)
            {
                print("Attack");
                myAnimator1.SetTrigger("Attack");
                myAnimator2.SetTrigger("Attack");
                onTrack.Invoke(); 
            }
            else
            {
                print("Idle");
                myAnimator1.SetTrigger("Idle");
                myAnimator2.SetTrigger("Idle");
                onLost.Invoke(); 
            }
        }
    }
}
