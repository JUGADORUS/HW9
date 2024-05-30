using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    [SerializeField] private ClickDetector _detector;

    public void Remove()
    {
        gameObject.SetActive(false);
    }
}
