using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private ClickDetector _detector;
    [SerializeField] private Divider _divider;
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
        List<Rigidbody> explodableObjects = _divider.Divide();

        if (explodableObjects.Count == 0)
        {
            _explosion.Explode(explodableObjects);
        }

        _objectRemover.Remove();
    }
}
