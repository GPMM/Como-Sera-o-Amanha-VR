using System.Collections;
using UnityEngine;

public class PrimaryReactor : MonoBehaviour
{
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window
    public Vector3 rotationAngle = new Vector3(45, 45, 45);
    public float rotationDuration = 0.25f; // seconds
    private Quaternion offRotation;
    private Quaternion onRotation;
    private Coroutine rotator;

    public GameObject Sala;
    public GameObject Cozi;

    public int i = 1;
    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        offRotation = this.transform.rotation;
        onRotation = Quaternion.Euler(rotationAngle) * offRotation;
    }

    public void onPrimaryButtonEvent(bool pressed)
    {
        IsPressed = pressed;
        if (pressed)
            Teste();
        
    }
    /*
    private IEnumerator AnimateRotation(Quaternion fromRotation, Quaternion toRotation)
    {
        float t = 0;
        while (t < rotationDuration)
        {
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, t / rotationDuration);
            t += Time.deltaTime;
            yield return null;
        }
    }*/
    public void Teste()
    {
        if (i > 0)
        {
            this.transform.position = Sala.transform.position;
        }
        else
        {
            this.transform.position = Cozi.transform.position;
        }
        i *= -1;
    }
}