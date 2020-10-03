﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCar : MonoBehaviour
{

    public List<TrainCarPerson> people;

    public List<float> peopleXPositions;
    public float peopleYPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Add(TrainCarPerson person)
    {

        if (people.Count >= peopleXPositions.Count) { return false; }

        person.transform.parent = transform;
        person.transform.localPosition = new Vector3(peopleXPositions[people.Count], peopleYPosition, 0);
        people.Add(person);

        return true;
    }
}
