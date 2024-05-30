using UnityEngine;

public class BehaviourOnClick : MonoBehaviour
{
    [SerializeField] private ClickDetector _detector;
    [SerializeField] private Multiplyer _multiplyer;
    [SerializeField] private ObjectRemover _objectRemover;
    [SerializeField] private Explosion _explosion;

    private void OnEnable()
    {
        ClickDetector _detector = GetComponent<ClickDetector>();
        _detector.Clicked += Act;
    }

    private void OnDisable()
    {
        _detector.Clicked -= Act;
    }

    private void Act()
    {
        _multiplyer.Multiply();
        _explosion.Explode();
        _objectRemover.Remove();
    }
}
