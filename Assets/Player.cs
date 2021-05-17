using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{

    public Vector3 firstPos, secPos, gap;
    public GameObject player;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            firstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButtonUp(0))
        {
            secPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            gap = secPos - firstPos;
            Instantiate(player, new Vector3(0,-3.94f,0), Quaternion.identity);
        }

        
    }
    
}
