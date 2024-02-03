using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

   [SerializeField] private GameObject player;

    private Vector3 tempPos;
   

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(2.5f, -0.01f, -1f);
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (!player) { return; }

        tempPos = gameObject.transform.position;
        tempPos.x = player.transform.position.x;

        if (tempPos.x < minX)
            tempPos.x = minX;

        if (tempPos.x > maxX)
            tempPos.x = maxX;

        gameObject.transform.position = tempPos;

    }



} // class






















