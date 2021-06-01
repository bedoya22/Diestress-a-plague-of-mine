﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bed_sleeping : MonoBehaviour
{
    public GameObject sleepText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            sleepText.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(sceneBuildIndex: 1);
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "Player")
        {
            sleepText.SetActive(false);
        }
    }
}