using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{

    public UXF.Session session;

    /*void MakeCubeAbove() {
    	cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 3, 0);
        Color brown = new Color(139f/255f, 69f/255f, 19f/255f, 1f);
        // color is controlled like this
        cube.GetComponent<Renderer>().material.color = brown;
    }*/

    void Start()
    {
        // MakeCubeAbove();
    }

    public void StartSession()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 0, 0);
        //session.CreateBlock(1);
        //session.FirstTrial.Begin();

        //Debug.Log("Beginning session...");
        //StartCoroutine(DelayedEnd());
    }

    public void StartTrial()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 0);
    }

    void Update()
    {
        //if (Time.frameCount % 20 == 0) {
        //    gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 256) / 255f, Random.Range(0, 1), Random.Range(0, 1));
        //}
    }

    public IEnumerator DelayedEnd()
    {
        Debug.Log("Beginning delay session end.");
        yield return new WaitForSeconds(3);
        Debug.Log("Ending session.");
        session.End();
    }

    public void EndSession()
    {
        session.End();
    }
}
