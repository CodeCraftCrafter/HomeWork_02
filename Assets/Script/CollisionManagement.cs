using UnityEngine;

public class CollisionManagement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Player"))
        {
                Players player = other.gameObject.GetComponent<Players>();

            if (player != null)
            {
                player.ChangeLife(-30);
                Debug.Log("Player has taken damage!");
            }
        }
    }
}