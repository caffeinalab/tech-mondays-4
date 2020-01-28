using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    int Count = 0;
    string[] Copy = new string[]{
        "Se lo bevi a colazione, poi diventerai un campione", 
        "Sono morti sono vivi, per prenderli li aspiri",
        "Se l'accendi senti i suoni, è la radio di ..."
    };

    public Text text;

    int treasure = 0;

    public void trackTreasure(int copyIndex){
        Debug.Log("copyIndex" + copyIndex + " -> " +  treasure);
        if (treasure != copyIndex) {
            return;
        }
        
        ++treasure;

        if (treasure < 3) {
            text.text = Copy[treasure];
        } else {
            text.text = "HAI VINTO!!!";
        }
    }
    // Start is called before the first frame update
    void Start()
    {           
        text = gameObject.GetComponent<Text>();
        text.text = Copy[0];
    }

    // Update is called once per frame
    void Update()
    {
    }
}
