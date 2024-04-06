using UnityEngine;

public class Players : Person
{
    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private int experience = 0;

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

    new public void ChangeLife(int change)
    {
        Life += change;
        if (change < 0) GainExperience(10);
    }

    private void GainExperience(int xp)
    {
        experience += xp;
        Debug.Log($"Gained {xp} experience points. Total XP: {experience}");
    }

    public override void ShowStat()
    {
        Debug.Log($"Name: {Name}, Experience: {experience}, Initial Life: {Life}");
    }

}