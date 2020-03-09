using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    private float fadeDuration;
    private float pauseDuration;
    private float originalOpacity;
    private bool isTransparent;
    public Material M;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        M = this.GetComponent<Renderer>().material;
        pauseDuration = Random.Range(1.6f,7.0f);
        isTransparent = false;
        originalOpacity = M.color.a;
        //fadeDuration = 0.03f;
        //StartCoroutine(FadeTo(M, targetOpacity, duration));
    }
    IEnumerator FadeTo(Material M, bool isTransparent, float fadeDuration, float originalOpacity)
    {
        //Debug.Log("fadeto is called");
        Color color = M.color;
        float startOpacity = color.a;
        float t = 0;
        float targetOpacity = 0;

        if (isTransparent)
        {
            targetOpacity = originalOpacity;
            
        }

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float blend = Mathf.Clamp01(t / fadeDuration);
            color.a = Mathf.Lerp(startOpacity, targetOpacity, blend);
            M.color = color;
            //Debug.Log("exiting fadeto");
            yield return null;

        }
        //StartCoroutine(FadeTo(M, targetOpacity, duration));
        //yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= pauseDuration)
        {
            pauseDuration = Random.Range(1.6f, 7.0f);
            fadeDuration = Random.Range(1.0f, (pauseDuration - 0.5f));
            timer = 0;

            if (M.color.a != 0.0f)
            {
                isTransparent = false;
            }
            else
            {
                isTransparent = true;
            }
            StartCoroutine(FadeTo(M, isTransparent, fadeDuration, originalOpacity));
            
        }
    }
}
