using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour
{
    public Text cordinates;
    // Start is called before the first frame update
    void Start()
    {
        // cordinates = GetComponent<TextMeshPro> ();
        // cordinates.text = "Hello";
    }

    // Update is called once per frame
    void Update()
    {
        cordinates.text = "Lat:" + GPS.Instance.latitude.ToString() + "   Long:" + GPS.Instance.longitude.ToString();
        //take this code and update text and desired content based on what location you are in!
    
    }
}
