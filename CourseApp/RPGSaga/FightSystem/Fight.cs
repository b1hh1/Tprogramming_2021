namespace RPGSagaW.FightSystem;
using RPGSagaW;
using RPGSagaW.Players;

public static class Fight
{
    public static void AtackPlayer(Player attacker, Player getAtack)
    {
        getAtack.Health -= attacker.Damage;
        Logger.PlayerAttack(attacker, getAtack);
    }

    public static bool CheckPlayerDeath(Player p1, Player p2)
    {
        if (p1.Health <= 0 || p2.Health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static Player CheckWinner(Player p1, Player p2)
    {
        if (p1.Health <= 0)
        {
            Logger.PlayerWin(p2);
            return p2;
        }
        else
        {
            Logger.PlayerWin(p1);
            return p1;
        }
    }

    public static List<object> SavePlayerStats(Player p1, Player p2)
    {
        List<object> stats = new List<object>();
        stats.Add(p1.Health);
        stats.Add(p1.Damage);
        stats.Add(p1.UsedAbility);
        stats.Add(p1.Stun);
        stats.Add(p1.PlayerAbility.Duration);
        stats.Add(p2.Health);
        stats.Add(p2.Damage);
        stats.Add(p2.UsedAbility);
        stats.Add(p2.Stun);
        stats.Add(p2.PlayerAbility.Duration);
        return stats;
    }

    public static void RestorePlayerStats(List<object> stats, Player p1, Player p2)
    {
        p1.Health = (int)stats[0];
        p1.Damage = (int)stats[1];
        p1.UsedAbility = (bool)stats[2];
        p1.Stun = (bool)stats[3];
        p1.PlayerAbility.Duration = (int)stats[4];
        p2.Health = (int)stats[5];
        p2.Damage = (int)stats[6];
        p2.UsedAbility = (bool)stats[7];
        p2.Stun = (bool)stats[8];
        p2.PlayerAbility.Duration = (int)stats[9];
    }

    public static void ReturnPlayerToList(Player p)
    {
        CreatePlayers.AddPlayerToList(p);
    }

    public static List<Player> SelectPlayersForFight(List<Player> players)
    {
        List<Player> playersForFight = new List<Player>();

        int p1 = Random.Shared.Next(0, players.Count);
        playersForFight.Add(players[p1]);
        players.Remove(players[p1]);

        int p2 = Random.Shared.Next(0, players.Count);
        playersForFight.Add(players[p2]);
        players.Remove(players[p2]);

        return playersForFight;
    }

    public static void StartFight(List<Player> players)
    {
        List<object> statsBeforeFight = SavePlayerStats(players[0], players[1]);

        int turn = Turn.RandomFirstTurn();

        while (CheckPlayerDeath(players[0], players[1]))
        {
            if (turn == 0)
            {
                if (FightAbility.CheckAbilityUse(players[0], players[0].UsedAbility) && FightAbility.ChanceToUseAbility())
                {
                    FightAbility.UseAbility(players[0], players[1]);
                    players[0].UsedAbility = true;
                    if (players[1].Stun)
                    {
                        players[1].Stun = false;
                        Turn.ChangeTurn(ref turn);
                    }
                }
                else
                {
                    AtackPlayer(players[0], players[1]);
                    if (players[0].PlayerAbility.Duration == 0)
                    {
                        players[0].Damage = (int)statsBeforeFight[1];
                    }
                }

                Turn.ChangeTurn(ref turn);
            }
            else
            {
                if (FightAbility.CheckAbilityUse(players[1], players[1].UsedAbility) && FightAbility.ChanceToUseAbility())
                {
                    FightAbility.UseAbility(players[1], players[0]);
                    players[1].UsedAbility = true;
                    if (players[0].Stun)
                    {
                        players[0].Stun = false;
                        Turn.ChangeTurn(ref turn);
                    }
                }
                else
                {
                    AtackPlayer(players[1], players[0]);
                    if (players[1].PlayerAbility.Duration == 0)
                    {
                        players[1].Damage = (int)statsBeforeFight[6];
                    }
                }

                Turn.ChangeTurn(ref turn);
            }
        }

        ReturnPlayerToList(CheckWinner(players[0], players[1]));

        RestorePlayerStats(statsBeforeFight, players[0], players[1]);
    }
}