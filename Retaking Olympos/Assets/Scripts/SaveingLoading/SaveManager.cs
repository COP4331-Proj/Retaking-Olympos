using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    public static void SavePlayerData(PlayerGladiator player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.RO";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static PlayerData LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/player.RO";

        // Gaurds against missing save
        if (!File.Exists(path))
        {
            Debug.LogError("Save file not found in: " + path);
            return null;
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        PlayerData data = formatter.Deserialize(stream) as PlayerData;
        stream.Close();

        return data;
    }

    public static void SaveEnemyData(EnemyGladiator enemy)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/enemy.RO";
        FileStream stream = new FileStream(path, FileMode.Create);

        EnemyData data = new EnemyData(enemy);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static EnemyData LoadEnemyData()
    {
        string path = Application.persistentDataPath + "/enemy.RO";

        // Gaurds against missing save
        if (!File.Exists(path))
        {
            Debug.LogError("Save file not found in: " + path);
            return null;
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        EnemyData data = formatter.Deserialize(stream) as EnemyData;
        stream.Close();

        return data;
    }
}
