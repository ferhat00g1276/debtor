using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debtor;

public class Debtor
{
    public Debtor(string fullName, DateTime birthday, string phone, string email, string address, int debt)
    {
        FullName = fullName;
        Birthday = birthday;
        Phone = phone;
        Email = email;
        Address = address;
        Debt = debt;
    }

    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public string Address { get; set; }
    public int Debt { get; set; }

    public override string ToString()
    {
        return $"{FullName} - {Birthday.ToShortDateString()} - {Phone} - {Email} - {Address} - {Debt}";
    }
}
