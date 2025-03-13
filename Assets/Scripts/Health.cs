using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPosition;
    public TMP_Text healthText;
    public EndScreenAnimation gameOverScreen; 




    private void Start()
    {
        respawnPosition = transform.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1); 
        }

        if (other.CompareTag("Checkpoint"))
        {
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;
        }

    }

    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"<b>Health</b> {points}";
        // HW
        //Add score in player collection script


        transform.position = respawnPosition;

        // points = 5;


        if (points < 1)
        {
            gameOverScreen.StartFade();
            Destroy(gameObject);
        }
    }

}
