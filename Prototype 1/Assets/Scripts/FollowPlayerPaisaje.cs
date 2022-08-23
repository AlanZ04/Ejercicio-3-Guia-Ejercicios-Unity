using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerPaisaje : MonoBehaviour
{
    public GameObject player;
    private Vector3 camatras = new Vector3(0, 100, -100);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + camatras;
    }
}
