using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    public void Remove()
    {
        gameObject.SetActive(false);
    }
}
