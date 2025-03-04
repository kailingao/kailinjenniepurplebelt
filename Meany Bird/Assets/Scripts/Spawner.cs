﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spikes Object for controlling the game")]
    public GameObject spikes;
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 5f, 4f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(10, Random.Range(-height, height), 0);

    }
    void InstantiateObjects()
    {
        Instantiate(spikes, transform.position, transform.rotation);
    }
}
