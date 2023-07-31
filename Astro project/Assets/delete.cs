using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public float DeleteTime;

    private void Awake()
     {  
        StartCoroutine(waiter());
     }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(DeleteTime);
        Object.Destroy(this.gameObject);
    }


}