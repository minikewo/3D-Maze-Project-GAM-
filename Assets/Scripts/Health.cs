using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);
        }

    }

    private void Damage(int value)
    {
        points = points - value;
        if (points < 1)
        {
            // HW
            // DO NOT DESTROY MOVE THE P{LAYER TO THE START AND RESET POINTS BACK TO 5

            Destroy(gameObject);
        }
    }

}
