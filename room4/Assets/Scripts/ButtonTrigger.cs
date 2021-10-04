using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public InputField answer;
    public string actualAns;
    public GameObject door;
    public GameObject key;
    public MouseLook mouseLook;
    public GameObject door2img;
    public AudioSource Correct;
    public AudioSource Incorrect;
    public AudioSource Dooropen;
    [SerializeField] private Animator MyAnimationController;


    public void onSubmit()
    {
        if (answer.text.ToUpper() == actualAns.ToUpper())
        {
            door.SetActive(false);
            door2img.SetActive(false);
            mouseLook.enabled = true;
            Debug.Log("You did it!");
            //  MyAnimationController.SetBool("open", true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Correct.Play();
            Dooropen.Play();

            


        }
        else
        {
            Incorrect.Play();
            Debug.Log(answer.text);
        }
    }

    





}
