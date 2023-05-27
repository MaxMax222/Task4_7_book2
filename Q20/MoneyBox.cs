namespace Q20
{
    public class MoneyBox
    {
        private double money;
        private string cahier;

        public MoneyBox(string cahier = "")
        {
            this.money = 0;
            this.cahier = cahier;
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public string Cahier
        {
            get { return cahier; }
            set { cahier = value; }
        }

        public override string ToString()
        {
            return $"Cashier name: {cahier}, Total income: {money}";
        }
    }
}