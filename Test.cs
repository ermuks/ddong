using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float timer = .0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2.55f)
        {
            timer -= 2.55f;
            Debug.Log("¤©¤·¤»¤»");
        }
    }
}
