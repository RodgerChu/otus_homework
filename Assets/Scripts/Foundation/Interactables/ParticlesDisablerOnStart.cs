using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesDisablerOnStart : MonoBehaviour
{
    [SerializeField] ParticleSystem[] _particles;

    private void Awake()
    {
        foreach (var particle in _particles)
            particle.Stop();
    }
}
