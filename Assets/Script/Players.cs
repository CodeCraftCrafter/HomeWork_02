using UnityEngine;

public class Players : Person
{
    [SerializeField]
    private float speed = 5.0f; // �������� �������� ������
    [SerializeField]
    private int experience = 0; // ���� ������

    void Start()
    {
        ShowStat();
    }

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector3.right;
        }

        transform.position += moveDirection * speed * Time.deltaTime;
    }

    // ���������� ������������ ������ TakeDamage
    public override void TakeDamage(int damageValue)
    {
        int finalDamage = Mathf.FloorToInt(damageValue * ImpactForce);
        Life -= finalDamage;

        GainExperience(10); // ������� ������ �� ��������� �����

        Debug.Log($"Player took {finalDamage} damage and gained experience. Remaining Life: {Life}");
    }

    private void GainExperience(int xp)
    {
        experience += xp;
        Debug.Log($"Gained {xp} experience points. Total XP: {experience}");
    }

    public override void ShowStat()
    {
        Debug.Log($"Name: {Name}, Experience: {experience}, Life: {Life}");
    }
}