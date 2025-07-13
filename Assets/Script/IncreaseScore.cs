using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SoundManager.Instance.EarnCoinSound();
            Score.instance.UpdateScore();
        }
    }
}
