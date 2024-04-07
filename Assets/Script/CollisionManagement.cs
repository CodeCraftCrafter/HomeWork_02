using UnityEngine;

public class CollisionManagement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �������� �� ���� � ������� �������
        Players player = other.GetComponent<Players>();
        Dragon dragon = GetComponent<Dragon>(); // ������������, ��� ������ ���������� � ������� Dragon

        if (player != null && dragon != null)
        {
            // ������ ������� ���� ������
            player.TakeDamage(dragon.Damage);

            // ����� � �������
            Debug.Log($"My name is {player.Name}");
            Debug.Log("I, the mighty dragon");
            Debug.Log($"Dragon caused {dragon.Damage} damage. Dragon's Life: {dragon.Life}");
            Debug.Log($"Player took {dragon.Damage} damage, remaining Life: {player.Life}, Experience: {player.Experience}");
        }
    }
}