using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen = false;
    private bool canBeInteractedWith = false;
    private Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // public override void OnFocus()
    // {

    // }

    // public override void OnInteract()
    // {
    //     if(canBeInteractedWith)
    //     {
    //         isOpen = !isOpen;

    //         Vector3 doorTransformDirection = transform.TransformDirection(Vector3.forward);
    //         Vector3 playerTransformDirection = FirstPersonController.instance.transform.position - transform.position;
    //         float dot = Vector3.Dot(doorTransformDirection,playerTransformDirection);

    //         anim.SetFloat("dot", dot);
    //         anim.SetBool("isOpen",isOpen);
    //     }
    //     throw new System.NotImplementedExpection();
    // }
    // Update is called once per frame
    // public override void OnLoseFocus()
    // {

    // }
}
