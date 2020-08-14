using System;
namespace PropertiesExercise
{
    public class Money
    {
        private float balance;
        public float USDBalance
        {
            get
            {
                return balance * .8f;
            }
        }
        public float AUDBalance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void AddMoney(float add)
        {
            AUDBalance += add;
        }
        public void LoseMoney(float loss)
        {
            AUDBalance -= loss;
        }
            
        
   
    }
}
