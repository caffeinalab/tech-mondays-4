using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Tesoro3 : DefaultTrackableEventHandler
{    
    protected override void OnTrackingFound(){
        base.OnTrackingFound();
        var ts = FindObjectsOfType<TextScript>()[0];
        ts.trackTreasure((int) 2);
    }

    protected override void OnTrackingLost(){
        base.OnTrackingLost();
    }

}
