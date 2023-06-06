using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<faceEnum, int> _cardValues = new Dictionary<faceEnum, int>()
        {
            [faceEnum.Two] = 2,
            [faceEnum.Three] = 3,
            [faceEnum.Four] = 4,
            [faceEnum.Five] = 5,
            [faceEnum.Six] = 6,
            [faceEnum.Seven] = 7,
            [faceEnum.Eight] = 8,
            [faceEnum.Nine] = 9,
            [faceEnum.Ten] = 10,
            [faceEnum.Jack] = 10,
            [faceEnum.Queen] = 10,
            [faceEnum.King] = 10,
            [faceEnum.Ace] = 1

        };

        private static int[] GetAllPossibleHandValue(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == faceEnum.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;
            for(int i =1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValue(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValue(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool ShoudDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValue(Hand);
            foreach(int value in possibleHandValues)
            {
                if (value > 16 && value < 22) return true;
            }
            return false;
        }
        public static bool? CompareHand(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValue(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValue(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
