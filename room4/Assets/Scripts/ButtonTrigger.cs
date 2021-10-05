using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public InputField answer;
    static int count = 0;
    public MouseLook mouseLook;
    public AudioSource Correct;
    public AudioSource Incorrect;
    public GameObject Collider;
    public GameObject popup;
    public GameObject stone;
    string[] actualAns = { "144", "190", "114", "7650" };

    public void onSubmit(int i)
    {
        if (answer.text.ToUpper() == actualAns[i].ToUpper())
        {
            count++;
            mouseLook.enabled = true;
            Debug.Log("You did it!");
            //  MyAnimationController.SetBool("open", true);
            Correct.Play();
            Collider.SetActive(false);
            popup.SetActive(false);
            if(count == 4)
            {
                stone.SetActive(true);
            }
        }
        else
        {
            Incorrect.Play();
            Debug.Log(answer.text);
        }
    }

    
    





}
