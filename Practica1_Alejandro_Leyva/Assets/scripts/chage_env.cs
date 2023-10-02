using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chage_env : MonoBehaviour
{
    public Transform[] Env_Objects;
    int counter;

    /// <summary>
    /// Button and Any touch implemented in two diferent code blocks
    /// </summary>
    
    /// Button
    private void Start()
    {
        counter = 0;
        Env_Objects[counter].gameObject.SetActive(true);
    }
    // Update is called once per frame

    public void prev_ChangeEnv() {
        change_env(-1);
        Debug.Log("Prev");
    }
    public void next_ChangeEnv()
    {
        change_env(1);
        Debug.Log("Next");
    }

    //Cycle throuhgt the env Array to show all game objects
    void change_env(int i)
    {
        Env_Objects[counter].gameObject.SetActive(false);
        counter = counter + i;
        if (counter > Env_Objects.Length - 1)
        {
            counter = 0;
        }
        else if (counter < 0)
        {
            counter = Env_Objects.Length-1;
        }
        Env_Objects[counter].gameObject.SetActive(true);
    }

    ///Any touch functionality
    /*
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
    }*/
}
