using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiBehavior : MonoBehaviour
{
    // search the "Player" object
    public GameObject player;

    //get the child SeeRange sphere
    public GameObject seeRange;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        seeRange = GameObject.Find("SeeRange");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
