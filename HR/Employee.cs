using System;

namespace HR;

internal class Employee: Person {
    private decimal _salary;

    public decimal Salary
    {
        get { return _salary; }
        set
        {
            if (value > 0) {
                _salary = value;
            }
            else {
                throw new ArgumentException("Salary must be positive");
            }
                
        }
    }

    private int _taxPercentage;
    public int TaxPercentage {
        get { return _taxPercentage; }
        set {
            if (value > 0 && value <= 40) {
                _taxPercentage = value;
            }
            else {
                throw new ArgumentException("Tax percentage must be between 1 and 40");
            }
        }
    }
}
