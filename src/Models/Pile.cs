namespace Exigy.ClockPatience.Models
{
    public class Pile
    {
        public int PositionId { get; private set; }
        public IList<Card> Cards { get; private set; }

        public Pile(int positionId)
        {
            PositionId = positionId;
            Cards = new List<Card>();
        }
    }
}
