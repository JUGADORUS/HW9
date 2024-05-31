using UnityEngine;

public class ActionOnClick : MonoBehaviour
{
    [SerializeField] private ClickDetector _detector;
    [SerializeField] private Divider _multiplyer;
    [SerializeField] private ObjectRemover _objectRemover;
    [SerializeField] private Explosion _explosion;

    private void OnEnable()
    {
        _detector.Clicked += Act;
    }

    private void OnDisable()
    {
        _detector.Clicked -= Act;
    }

    private void Act()
    {
        _multiplyer.Divide();
        _explosion.Explode();
        _objectRemover.Remove();
    }
}
