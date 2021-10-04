using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public InputField answer;

    public MouseLook mouseLook;
    public AudioSource Correct;
    public AudioSource Incorrect;
    public GameObject Collider;
    public GameObject popup;
    string[] actualAns = { "144", "190", "114", "7650" };

    public void onSubmit(int i)
    {
        if (answer.text.ToUpper() == actualAns[i].ToUpper())
        {
            
            mouseLook.enabled = true;
            Debug.Log("You did it!");
            //  MyAnimationController.SetBool("open", true);
            Correct.Play();
            Collider.SetActive(false);
            popup.SetActive(false);
        }
        else
        {
            Incorrect.Play();
            Debug.Log(answer.text);
        }
    }

    





}
