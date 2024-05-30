using UnityEngine;

public class ColorDefiner : MonoBehaviour
{
    private void Start()
    {
        DefineColor();
    }

    private void DefineColor()
    {
        float randomChannelOne = Random.Range(0f, 1f);
        float randomChannelTwo = Random.Range(0f, 1f);
        float randomChannelThree = Random.Range(0f, 1f);

        gameObject.GetComponent<Renderer>().material.color = new Color(randomChannelOne, randomChannelTwo, randomChannelThree);
    }
}
