using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenAnimation : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    
    public void StartFade()
    {
        StartCoroutine(FadeInOutRoutine()); 
    }

    private IEnumerator FadeInOutRoutine()
    {
        float duration = 0.5f;
        float time = 0f;


        yield return new WaitForSeconds(0.25f);

        //fade in 
        while (time<duration)
        {
            time += Time.deltaTime;
            float distance = time / duration;
            canvasGroup.alpha = distance;
            yield return new WaitForEndOfFrame();        
        }

        yield return new WaitForSeconds(1f);

        //fade out
        while (time > 0 )
        {
            time = time - Time.deltaTime;
            float distance = time / duration;
            canvasGroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }



        //reset
        SceneManager.LoadScene("SampleScene");
        

    }
}
