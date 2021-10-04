using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAppear : MonoBehaviour
{
  
    public GameObject _noteImage;
    public  MouseLook mouseLook;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.SetActive(true);
            mouseLook.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.SetActive(false);
            mouseLook.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
    }
}