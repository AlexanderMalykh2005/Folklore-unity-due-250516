using UnityEngine;

public class test : MonoBehaviour
{
    private GameObject interactionmessage;
    
    void Start()
//where things are triggered upon start
    {

    }

    // Update is called once per frame
    void Update()
//constantly updated / checked 
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            print("bruh");
        }
    }
}
