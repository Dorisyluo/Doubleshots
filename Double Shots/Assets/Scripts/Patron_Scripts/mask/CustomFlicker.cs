using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFlicker : MonoBehaviour
{
    private float pauseDuration; //duration of pauses between actual flickering
    public Material M;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        M = this.GetComponent<Renderer>().material;
        pauseDuration = Random.Range(0.1f, 1.0f);
        M.EnableKeyword("_EMISSION");
        //M.DisableKeyword("_EMISSION");
    }
    IEnumerator SwitchTo(Material M)
    {
        //Debug.Log("fadeto is called");
        

        if (M.IsKeywordEnabled("_EMISSION"))
        {
            M.DisableKeyword("_EMISSION");


        }
        else
        {
            M.EnableKeyword("_EMISSION");
        }
        yield return null;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= pauseDuration)
        {
            pauseDuration = Random.Range(0.1f, 1.0f);
            timer = 0;

            StartCoroutine(SwitchTo(M));
            
        }
    }
}
