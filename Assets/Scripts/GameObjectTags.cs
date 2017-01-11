using UnityEngine;
using System.Collections;

public class GameObjectTags : MonoBehaviour
{
    private static string _playerTag;
    private static string _enemyTag;

    private void Start()
    {
        _playerTag = "Player";
        _enemyTag = "Enemy";
    }

    public static string GetPlayerTag()
    {
        return _playerTag;
    }

    public static string GetEnemyTag()
    {
        return _enemyTag;
    }
}
