using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bomb", menuName = "Bomb", order = 51)]
public class Bomb : Prize
{
    public override void AddPrize(List<Prize> prizes)
    {
        foreach (var item in prizes)
        {
            if (item is Coin)
            {
                var coin = (Coin)item;
                coin.SetZeroCount();
            }
        }
    }
}
