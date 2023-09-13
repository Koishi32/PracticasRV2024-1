using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject [] carros;

    public float velo;
    Transform currentSelected;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        currentSelected = carros[0].transform;
        carros[1].SetActive(false);
        carros[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rotate_carrusel();
    }

    void rotate_carrusel() {
        currentSelected.Rotate(Vector3.up, 1 * velo);
        if (currentSelected.rotation.y < 0)
        {
            carros[index].SetActive(false);
            index++;
            if (index > 2)
            {
                index = 0;
            }
            currentSelected = carros[index].transform;
            currentSelected.rotation = Quaternion.identity;
            carros[index].SetActive(true);
        }
    }

}
