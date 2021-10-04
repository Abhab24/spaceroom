using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteAppear : MonoBehaviour
{
    [SerializeField]
    private GameObject _noteImage;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.SetActive(true);
        }

    }


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.SetActive(false);
        }
    }
}