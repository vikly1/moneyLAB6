using System;
int[] coins = new int[12];
string size = "abc";
int[] sizecoin = new int[2] { -1, 1 };
Random random = new Random();
int fake = 20;
coins[random.Next(0, 12)] = sizecoin[random.Next(0, 2)];
foreach (int coin in coins)
{
    Console.Write(coin + "  ");
}
int firstsize1 = coins[0] + coins[1] + coins[2] + coins[3];
int firstsize2 = coins[4] + coins[5] + coins[6] + coins[7];
int firstsize3 = coins[8] + coins[9] + coins[10] + coins[11];

if (firstsize1 == firstsize2)
{
    if (coins[0] + coins[1] + coins[2] == coins[8] + coins[9] + coins[10])
    {
        fake = 12;
        if (coins[5] > coins[11])
        {
            size = "меньше";
        }
        else
        {
            size = "больше";
        }
    }
    else if (coins[0] + coins[1] + coins[2] > coins[8] + coins[9] + coins[10])
    {
        size = "меньше";
        if (coins[8] == coins[9])
        {
            fake = 11;
        }
        else if (coins[8] > coins[9])
        {
            fake = 10;
        }
        else
        {
            fake = 9;
        }
    }
    else
    {
        size = "меньше";
        if (coins[9] > coins[10])
        {
            fake = 10;
        }
        else if (coins[9] < coins[10])
        {
            fake = 11;
        }
        else
        {
            fake = 9;
        }
    }
}
else if (firstsize1 > firstsize2)
{
    if (coins[0] + coins[1] + coins[4] == coins[2] + coins[3] + coins[8])
    {
        size = "меньше";
        if (coins[5] > coins[6])
        {
            fake = 7;
        }
        else if (coins[5] < coins[6])
        {
            fake = 6;
        }
        else
        {
            fake = 8;
        }
    }
    else if (coins[0] + coins[1] + coins[4] > coins[2] + coins[3] + coins[8])
    {
        size = "больше";
        if (coins[0] > coins[1])
        {
            fake = 1;
        }
        else
        {
            fake = 2;
        }
    }
    else if (coins[0] + coins[1] + coins[4] < coins[2] + coins[3] + coins[8])
    {
        if (coins[2] == coins[3])
        {
            size = "меньше";
            fake = 5;
        }
        else if (coins[2] > coins[3])
        {
            size = "больше";
            fake = 3;
        }
        else if (coins[2] < coins[3])
        {
            size = "больше";
            fake = 4;
        }
    }
}
else if (firstsize1 < firstsize2)
{
    if (coins[0] + coins[1] + coins[4] == coins[2] + coins[3] + coins[8])
    {
        size = "больше";
        if (coins[5] > coins[6])
        {
            fake = 6;
        }
        else if (coins[5] < coins[6])
        {
            fake = 7;
        }
        else
        {
            fake = 8;
        }
    }
    else if (coins[0] + coins[1] + coins[4] < coins[2] + coins[3] + coins[8])
    {
        size = "меньше";
        if (coins[0] < coins[1])
        {
            fake = 1;
        }
        else
        {
            fake = 2;
        }
    }
    else if (coins[0] + coins[1] + coins[4] > coins[2] + coins[3] + coins[8])
    {
        if (coins[2] == coins[3])
        {
            fake = 5;
            size = "больше";
        }
        else if (coins[2] > coins[3])
        {
            size = "меньше";
            fake = 4;
        }
        else if (coins[2] < coins[3])
        {
            size = "меньше";
            fake = 3;
        }
    }
}
Console.WriteLine($"Фальшивка обозначена номером {fake} и она {size} подлинной");
