using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float velo;
    public float yLimitUp;
    public float yLimitDown;
    bool Ascending;
    // Update is called once per frame
    void Update()
    {
        if (Ascending && this.transform.localPosition.y < yLimitUp) {
            this.transform.localPosition = this.transform.localPosition + (Vector3.up * velo * Time.deltaTime);
        } else {
            Ascending = false;
        }

        if (!Ascending && this.transform.localPosition.y > yLimitDown)
        {
            this.transform.localPosition = this.transform.localPosition - (Vector3.up * velo * Time.deltaTime);
        }
        else {
            Ascending = true;
        }

        
    }

    private void Start()
    {
        Ascending = true;
    }
}
