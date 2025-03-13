using TMPro;
using UnityEngine;

public class PlayerCollection : MonoBehaviour

{
    private int score = 0;
    public TMP_Text scoreText;
    private void OnTriggerEnter(Collider other)
    {
        // Only destroy if collectable
        if (other.CompareTag("Collectable"))
        {
            Addscore(points: 1);
            Destroy(other.gameObject);
        }
    }
    private void Addscore(int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score:</b> {score}";
    }
}
