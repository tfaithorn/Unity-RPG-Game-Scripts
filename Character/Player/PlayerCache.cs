using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerCache
{
    private static Dictionary<long, Player> players;
    private static Player lastPlayedPlayer;
    private static List<Player> playerList;

    static PlayerCache()
    {
        players = new Dictionary<long, Player>();

        var playerRepository = new PlayerRepository();
        playerList = playerRepository.GetPlayers();

        foreach (var player in playerList)
        {
            if (lastPlayedPlayer == null || lastPlayedPlayer.lastPlayed > player.lastPlayed)
            {
                lastPlayedPlayer = player;
            }

            players.Add(player.id, player);
        }
    }

    public static Player GetPlayer(long playerId)
    {
        return players[playerId];
    }

    public static Player GetLastPlayed()
    {
        return lastPlayedPlayer;
    }

    public static List<Player> GetPlayerList()
    {
        return playerList;
    }

    public static void AddNewPlayer(Player player)
    {
        players[player.id] = player;

        if (!playerList.Exists(x => x == player))
        {
            playerList.Add(player);
        }

        lastPlayedPlayer = player;
    }
}
