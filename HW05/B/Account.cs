using System;
namespace B
{
    public class Account
    {
        private string _name;
        public float Withdraw(float amount, float bal)
        {
            if (amount > bal)
            {
                Console.WriteLine("Withdrawal amount exceeded account balance.");
                return bal;
            }
            return bal - amount;
        }
        public Account(string name)
        {
            // D'Morgan's Law
            // A||B == !(!A && !B)
            // A&& B == !(!A || !B)
            //if(!(name == null || name == ""))
            // if(name != null && name != "")
            if (!string.IsNullOrEmpty(name))
                Name = name;
            Is_Active = true;
            IsActive = true;
            //_name = name;

            // Name = name;
        }

        public Account(string name, bool isActive)
        {
            Name = name;
            IsActive = Is_Active = isActive;
        }

        public override string ToString()
        {
            //return GetType().FullName; // prints out the fully qualified type name
            //return base.ToString();
            if (IsActive)
                return ($"Active Account {Name}");
            else
                return ($"Inactive Account {Name}");
        }
        public readonly bool Is_Active; // field

        public bool IsActive
        {
            get; private set; // state
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null && value != "")
                    _name = value;
            }
        }
    }
}
