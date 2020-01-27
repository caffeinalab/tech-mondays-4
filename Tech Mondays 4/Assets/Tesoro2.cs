using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Tesoro2 : DefaultTrackableEventHandler
{    
    protected override void OnTrackingFound(){
        base.OnTrackingFound();
        var ts = FindObjectsOfType<TextScript>()[0];
        ts.trackTreasure((int) 1);
    }

    protected override void OnTrackingLost(){
        base.OnTrackingLost();
    }

}
