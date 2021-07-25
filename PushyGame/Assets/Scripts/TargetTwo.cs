using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // for text

public class TargetTwo : MonoBehaviour
{
    public string displayText;
    public GameObject bridge3;
    public TextMeshProUGUI countText;

    // Start is called before the first frame update
    void Start()
    {
        bridge3.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            countText.text = displayText;
            bridge3.SetActive(true);
            gameObject.SetActive(false); 
        }
    }
}
