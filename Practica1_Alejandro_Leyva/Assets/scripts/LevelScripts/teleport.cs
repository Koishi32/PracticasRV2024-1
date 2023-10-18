using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform Player_position;
    static float OffsetY;
    // Start is called before the first frame update
    private void Start()
    {
        OffsetY = 1.5f;
    }
    public void OnPointerEnter() {

    }


    public void OnPointerExit() {

    }

    //transport player to hit position and add offset on Y to elevate
    public void OnPointerClick(RaycastHit hit) {
        Vector3 PosOfHit = hit.point;
        Player_position.position = PosOfHit + Vector3.up*OffsetY;
    }
}
