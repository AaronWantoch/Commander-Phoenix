using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersHandler : MonoBehaviour
{
    public static CharactersHandler instance;

    public static List<EnemyAI> enemies = new List<EnemyAI>();
    public static List<FriendAI> soliders = new List<FriendAI>();

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    //TODO make it so clossest enemy is found
    public static EnemyAI FindEnemy(Transform transform, float detectionDistance)
    {

        foreach(EnemyAI enemy in enemies )
        {
            if (Vector3.Distance(transform.position, enemy.transform.position)
                < detectionDistance)
            {
                return enemy;
            }
        }
        return null;
    }

    public static FriendAI FindFriendly(Transform transform, float detectionDistance)
    {

        foreach (FriendAI solider in soliders)
        {
            if (Vector3.Distance(transform.position, solider.transform.position)
                < detectionDistance)
            {
                return solider;
            }
        }
        return null;
    }

}
