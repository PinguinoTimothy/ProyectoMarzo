using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGizmo : MonoBehaviour
{
    List<EnemyGizmos> enemies;

    void Start()
    {
        enemies = new List<EnemyGizmos>(FindObjectsOfType<EnemyGizmos>());
    }

    private void OnDrawGizmos()
    {
        if (enemies == null || enemies.Count == 0)
            return;
        Gizmos.color = Color.green;
        EnemyGizmos closerEnemy = null;
        float closer = float.MaxValue;

        foreach (var e in enemies)
        {
            float distance = Vector3.Distance(transform.position, e.transform.position);

            if (distance < closer)
            {
                closer = distance;
                closerEnemy = e;
            }
        }
        if (closerEnemy)
        {
            Gizmos.DrawLine(transform.position, closerEnemy.transform.position);
        }
    }
}