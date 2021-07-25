using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // for text

public class CollisionResult : MonoBehaviour
{
    private Rigidbody rbTarget;
    public TextMeshProUGUI countText;
    public GameObject bridge2;

    // Start is called before the first frame update
    void Start()
    {
        rbTarget = GetComponent<Rigidbody>();
        bridge2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called by unity when the player entity first touches a trigger collider and is given a reference
    // to the trigger collider that will be touched
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pushy"))
        {
            // for this project we only deactivate the game object rather than dsetory it
            gameObject.SetActive(false); 
            countText.text = "Nice! Part 1 done.";
            bridge2.SetActive(true);
            other.gameObject.SetActive(false);

        } 
        else if (other.gameObject.CompareTag("Player")) 
        {
            countText.text = "Hmmm what's this?";
        }
    }
}
