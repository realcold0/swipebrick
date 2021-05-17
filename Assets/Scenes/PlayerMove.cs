using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Player player = GameObject.Find("BallSpawn").GetComponent<Player>();
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,1,0 );

    }
}
