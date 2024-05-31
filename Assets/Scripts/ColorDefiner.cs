using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorDefiner : MonoBehaviour
{
    private void Start()
    {
        Define();
    }

    private void Define()
    {
        float randomChannelOne = Random.Range(0f, 1f);
        float randomChannelTwo = Random.Range(0f, 1f);
        float randomChannelThree = Random.Range(0f, 1f);

        gameObject.GetComponent<Renderer>().material.color = new Color(randomChannelOne, randomChannelTwo, randomChannelThree);
    }
}
