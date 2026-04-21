using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FadeManager : MonoBehaviour
{
    
    [SerializeField] private Animator fadeAnimator;
    
    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeAndLoad(sceneName));
    }

    private IEnumerator  FadeAndLoad(string sceneName)
    {
        fadeAnimator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1f); // Wait for the fade animation to complete
        SceneManager.LoadScene(sceneName);
    }

    void Start()
    {
        fadeAnimator.SetTrigger("FadeIn");
    }
    




}