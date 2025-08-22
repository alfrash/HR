using System;

namespace HR;

internal abstract class Person {
    public String FirstName { get; private set; }
    public String LastName { get; set; }
    public DateOnly DateOfBirth { get; private set; }
    
    public void SetDateOfBirth(DateOnly dateOfBirth) {
        if (dateOfBirth < new DateOnly(1984, 1, 1))
            throw new ArgumentException("Invalid date of birth");
        DateOfBirth = dateOfBirth;
    }

    public void SetName(string firstName, string lastName) {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("Invalid name");
        FirstName = firstName;
        LastName = lastName;
    }
}
