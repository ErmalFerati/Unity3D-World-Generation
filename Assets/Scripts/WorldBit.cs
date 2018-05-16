using System.Collections;
using UnityEngine;

public class WorldBit : MonoBehaviour
{
    public Vector3 size;
    public WorldBit[] matchingWorldBits;

    /// <summary>
    /// Example use of a world bit spawn, can be used with timers, triggers etc.
    /// </summary>
    /// <returns></returns>
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        WorldGeneration.instance.generateWorldBit(transform.position + size);
    }
}