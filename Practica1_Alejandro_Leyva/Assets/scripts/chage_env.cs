using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chage_env : MonoBehaviour
{
    public Transform[] Env_Objects;
    int counter;

    private void Start()
    {
        counter = 0;
        Env_Objects[counter].gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0) {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                change_env();
            }
        }

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0)) {
            change_env();
        }
    #endif

    }

    void change_env() {
        Env_Objects[counter].gameObject.SetActive(false);
        counter++;
        if (counter > Env_Objects.Length-1)
        {
            counter = 0;
        }
        Env_Objects[counter].gameObject.SetActive(true);
    }
}
