using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 35.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyArrow());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    IEnumerator DestroyArrow()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }

}
