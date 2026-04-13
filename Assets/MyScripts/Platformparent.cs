using UnityEngine;

public class Platformparent : MonoBehaviour
{
    public Transform player;
    public Transform parentObject;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something entered elevator trigger");
        if (other.tag == "Player")
        {   
            Debug.Log("Player entered platform trigger");

            if(player == null) player = other.transform;
                
            player.parent = parentObject;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("something exited elevator trigger");
        if (other.tag == "Player")
        {   
            Debug.Log("Player exited platform trigger");
            if(player == null) player = other.transform;
            
            player.parent = null;
            
        }
    }
}
