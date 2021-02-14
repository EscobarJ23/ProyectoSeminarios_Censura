using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


[Serializable]
public class AnalysisObject
{

    public double AdultClassificationScore { get; set; }
    public bool IsImageAdultClassified { get; set; }
    public double RacyClassificationScore { get; set; }
    public bool IsImageRacyClassified { get; set; }
    public bool Result { get; set; }

}

