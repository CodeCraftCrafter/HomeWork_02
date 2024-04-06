using UnityEngine;

public class CollisionManagement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������, �������� �� ������, � ������� ��������� ������������, ��������� Person
        Person person = other.GetComponent<Person>();

        if (person != null)
        {
            // ������� ����, ������� ����� TakeDamage
            person.TakeDamage(30); // ��������������, ��� �������� ����� ����� 30

            Debug.Log("Damage applied to the player.");
        }
    }
}