using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveParticleAction : MonoBehaviour
{
    public ParticleSystem[] particles = null;
	
	public void Execute(bool newState)
    {
        for(int i = 0; i < particles.Length; i++)
        {
            if(particles[i].isPlaying != newState)
            {
                if (newState)
                    particles[i].Play();
                else
                    particles[i].Stop();
            }
        }
    }
}
