using System;
using UnityEngine;
using UnityEngine.UI;

public class MathFSample : MonoBehaviour
{
    public Slider lerpSlider;
    [SerializeField] public float lerpSpeed = 0.1f; // exposed speed
    [SerializeField] public float lerpT = 0.25f;    // exposed t value
    public float pingPongSpeed, moveTowardSpeed;
    public Slider pingPongSlider;
    public Slider moveTowardSlider;

    public GameObject upDown;
    public void MoveTowardsSample()
    {
        moveTowardSlider.value = Mathf.MoveTowards(moveTowardSlider.value, moveTowardSlider.maxValue, moveTowardSpeed * Time.deltaTime);
    }
    void Update()
    {
        LerpSamples();
        PingPongSamples();
        MoveTowardsSample();
        SinSamples();

    }

    public void PingPongSamples()
    {
        pingPongSlider.value = Mathf.PingPong(Time.time * pingPongSpeed, pingPongSlider.maxValue);
    }

    public void LerpSamples()
    {
        float startValue = 0f;
        float endValue = 10f;

        float value = Mathf.Lerp(startValue, endValue, lerpT);
        Debug.Log(value);

        // increment lerpT based on inspector speed
        lerpT += Time.deltaTime * lerpSpeed;
        lerpT = Mathf.Clamp01(lerpT); // optional: clamp here or inside Lerp

        lerpSlider.value = Mathf.Lerp(0, 100, lerpT);
    }
    public void absSamples()
    {
        float absVal = Mathf.Abs(-25);
    }

    public void RepeatSample()
    {
        float repeatedValue = Mathf.Repeat(Time.time, 5f);
        Debug.Log("Repeated Value" + repeatedValue);
    }

    public void RoundSamples()
    {
        Mathf.Round(123.35f);
    }

    public void SinSamples()
    {
        float amplitude = 1f;
        float frequency = 1f;
        Vector3 startPos;
        startPos = upDown.transform.position;
        float verticalMovement = MathF.Sin(Time.time * frequency) * amplitude;
        upDown.transform.position = new UnityEngine.Vector3(0, verticalMovement, 0);
    }
}
