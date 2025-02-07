using System;

enum Rating
{
    Good, Great, Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string nme, float ag, string ow, Rating rting)
    {
        name = nme;
        age = ag;
        owner = ow;
        rating = rting;
    }

    public override string ToString()
    {
        return "Dog Name: " + name + "\nAge: "+ age + "\nOwner: "+ owner + "\nRating: "+ rating;
    }
}
